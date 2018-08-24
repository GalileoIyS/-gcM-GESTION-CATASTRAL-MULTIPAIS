import L from 'leaflet';
import React from 'react';
import { withStyles } from '@material-ui/core/styles';
import { Map, TileLayer, ZoomControl, WMSTileLayer, LayersControl } from 'react-leaflet';
import Drawer from '@material-ui/core/Drawer';
import "proj4leaflet"
import "proj4"

import DetailPage from '../detail/DetailPage';

const { BaseLayer, Overlay } = LayersControl
const styles = theme => ({
  infoMapaContainer: {
    zIndex: 1000,
    position: 'fixed',
    display: 'block',
    textAlign: 'center',
    width: '100%',
    top: 80
  },
  infoMapaText: {
    backgroundColor: '#fff',
    width: '40%',
    margin: '0 auto',
    padding: '10px',
    boxShadow: '10px 10px 15px grey',
    fontSize: '1.2em'
  }
});

class LeafletPage extends React.Component {
  constructor(props) {
    super(props)
    this.state = {
      lat: 4.08,
      lng: -76.19,
      zoom: 13,
      right: false,
      oid: null
    }
  }
  handleClick = (ev) => {
    var url = this.getFeatureInfoUrl(this.refs.map.leafletElement, this.refs.catastro.layer, ev.latlng, "");
    var res = url.replace("89.17.213.131", "localhost");

    fetch('http://gcmserver.galileoiys.es/api/detalle/', {
      method: 'post',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify({ "address": res })
    }).then((resp) => { return resp.json() }).then((data) => {

      var datos = JSON.parse(data);

      if (datos.features.length > 0) {
        this.setState({
          'right': true,
          'oid': datos.features[0].properties.oid
        });
      }
    });
  }

  toggleDrawer = (side, open) => () => {
    this.setState({
      'right': open,
    });
  };

  getFeatureInfoUrl = (map, layer, latlng, params) => {

    var point = map.latLngToContainerPoint(latlng, map.getZoom()),
      size = map.getSize(),
      bounds = map.getBounds(),
      sw = bounds.getSouthWest(),
      ne = bounds.getNorthEast();

    var defaultParams = {
      request: 'GetFeatureInfo',
      service: 'WMS',
      srs: "EPSG:4326",
      styles: '',
      version: layer._wmsVersion,
      format: layer.options.format,
      bbox: [sw.lng, sw.lat, ne.lng, ne.lat],
      height: size.y,
      width: size.x,
      layers: layer.options.layers,
      query_layers: layer.options.layers,
      info_format: 'application/json',
      featurecount: 1
    };

    params = L.Util.extend(defaultParams, params || {});

    params[params.version === '1.3.0' ? 'i' : 'x'] = point.x;
    params[params.version === '1.3.0' ? 'j' : 'y'] = point.y;

    return layer._url + L.Util.getParamString(params, layer._url, true);
  }

  render() {
    const { classes } = this.props
    const position = [this.state.lat, this.state.lng]
    const currentmap = this.props.location.state.layer

    return (
      <div>
        <Map center={position} zoom={this.state.zoom} zoomControl={false} onClick={this.handleClick} ref='map' crs={L.CRS.EPSG900913}>
          <LayersControl position="bottomright">
            <BaseLayer checked name="OpenStreetMap.Mapnik">
              <TileLayer
                attribution="&amp;copy <a href=&quot;http://osm.org/copyright&quot;>OpenStreetMap</a> contributors"
                url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
              />
            </BaseLayer>
            <BaseLayer name="Esri.WorldImagery">
              <TileLayer
                attribution="Tiles &copy; Esri &mdash; Source: Esri, i-cubed, USDA, USGS, AEX, GeoEye, Getmapping, Aerogrid, IGN, IGP, UPR-EGP, and the GIS User Community"
                url="https://server.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer/tile/{z}/{y}/{x}"
              />
            </BaseLayer>
            <Overlay name="Catastro" checked ref='catastro' >
              <WMSTileLayer
                layers={currentmap}
                url="http://89.17.213.131:8086/geoserver/Postgis/ows"
                transparent={true}
                format={'image/png'}
              />
            </Overlay>
          </LayersControl>
          <ZoomControl position="bottomleft" />
          <div className={classes.infoMapaContainer}>
            <p className={classes.infoMapaText}>
              Pulse en cualquier zona del mapa para acceder a <strong>más Información</strong> y al <strong>StreetView</strong>
            </p>
          </div>
        </Map>
        <Drawer anchor="right" open={this.state.right} onClose={this.toggleDrawer('right', false)}>
          <div
            tabIndex={0}
            role="button"
            onKeyDown={this.toggleDrawer('right', false)}>
            <DetailPage oid={this.state.oid} />
          </div>
        </Drawer>
      </div>
    )
  }
}

export default withStyles(styles, { withTheme: true })(LeafletPage);
