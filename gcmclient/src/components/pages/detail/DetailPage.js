import React from 'react';
import { withStyles } from '@material-ui/core/styles';
import ExpansionPanel from '@material-ui/core/ExpansionPanel';
import ExpansionPanelSummary from '@material-ui/core/ExpansionPanelSummary';
import ExpansionPanelDetails from '@material-ui/core/ExpansionPanelDetails';
import Typography from '@material-ui/core/Typography';
import ExpandMoreIcon from '@material-ui/icons/ExpandMore';
import List from '@material-ui/core/List';
import ListItem from '@material-ui/core/ListItem';
import ListItemText from '@material-ui/core/ListItemText';
import ListItemSecondaryAction from '@material-ui/core/ListItemSecondaryAction';
import ImageIcon from '@material-ui/icons/Image';
import Card from '@material-ui/core/Card';
import CardHeader from '@material-ui/core/CardHeader';
import CardContent from '@material-ui/core/CardContent';
import Avatar from '@material-ui/core/Avatar';
import IconButton from '@material-ui/core/IconButton';
import MoreVertIcon from '@material-ui/icons/MoreVert';
import GavelIcon from '@material-ui/icons/Gavel';
import BusinessIcon from '@material-ui/icons/Business';
import NaturePeopleIcon from '@material-ui/icons/NaturePeople';
import FilterIcon from '@material-ui/icons/Filter';
import EuroIcon from '@material-ui/icons/EuroSymbol';
import ListItemIcon from '@material-ui/core/ListItemIcon';
import Divider from '@material-ui/core/Divider';
import purple from '@material-ui/core/colors/purple';

const styles = theme => ({
    formInside: {
        width: 350,
        position: 'relative',
        padding: '0px',
    },
    card: {
        maxWidth: 400,
        backgroundColor: '#fff'
    },
    media: {
        height: 0,
        paddingTop: '56.25%', // 16:9
    },
    actions: {
        display: 'flex',
    },
    expand: {
        transform: 'rotate(0deg)',
        transition: theme.transitions.create('transform', {
            duration: theme.transitions.duration.shortest,
        }),
        marginLeft: 'auto',
        [theme.breakpoints.up('sm')]: {
            marginRight: -8,
        },
    },
    expandOpen: {
        transform: 'rotate(180deg)',
    },
    avatar: {
        backgroundColor: purple[500]
    },
    descriptions: {
        paddingLeft: '0px',
        paddingRight: '0px'
    },
    listItem: {
        padding: '0px'
    },
    valuesContainer: {
        display: 'flex',
        padding: 10
    },
    values: {
        flexGrow: 1,
        padding: 8,
        textAlign: 'right'
    }
});

class DetailPage extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            expanded: false,
            oid: props.oid,
            info: {},
            valuation: [],
            taxation: [],
            unit: [],
            right: [],
            crop: [],
            isLoading: false
        };
    }

    initializeMap(canvas) {
        if (this.props.googleMaps && this.streetView == null) {
            this.streetView = new this.props.googleMaps.StreetViewPanorama(canvas, this.props.streetViewPanoramaOptions
            );
        }
    }

    handleExpandClick = () => {
        this.setState(state => ({ expanded: !state.expanded }));
    };


    componentDidMount() {
        const { classes } = this.props;

        this.setState({ isLoading: true });

        fetch('http://gcmserver.galileoiys.es/api/detalle/' + this.state.oid)
            .then(response => response.json())
            .then(data => {
                let crops = data.vw_crops.map((item) => {
                    return (
                        <ListItem className={classes.listItem}>
                            <Avatar style={{ backgroundColor: purple[200] }}>
                                <ImageIcon />
                            </Avatar>
                            <ListItemText primary={item.crop_type_desc} secondary={item.economic_value} />
                        </ListItem>
                    )
                })

                let valuations = data.vw_ext_cur_valuation.map((item) => {
                    return (
                        <ListItem className={classes.listItem}>
                            <Avatar style={{ backgroundColor: purple[200] }}>
                                <EuroIcon />
                            </Avatar>
                            <ListItemText primary={item.value_type_desc} secondary={item.value + ' $'} />
                        </ListItem>
                    )
                })

                let taxations = data.vw_ext_cur_taxation.map((item) => {
                    return (
                        <ListItem className={classes.listItem}>
                            <Avatar style={{ backgroundColor: purple[200] }}>
                                <GavelIcon />
                            </Avatar>
                            <ListItemText primary={item.tax_type_desc} secondary={item.amount + ' $'} />
                        </ListItem>
                    )
                })

                let rights = data.vw_right.map((item) => {
                    return (
                        <ListItem className={classes.listItem}>
                            <Avatar style={{ backgroundColor: purple[200] }}>
                                <ImageIcon />
                            </Avatar>
                            <ListItemText primary={item.right_type_desc} secondary={item.party_name} />
                        </ListItem>
                    )
                })

                let units = data.vw_ba_unit.map((item) => {
                    return (
                        <ListItem className={classes.listItem}>
                            <Avatar style={{ backgroundColor: purple[200] }}>
                                <NaturePeopleIcon />
                            </Avatar>
                            <ListItemText primary={item.adm_use_descrip} secondary={item.area} />
                        </ListItem>
                    )
                })

                this.setState({
                    info: data.vw_spatial_unit,
                    valuation: valuations,
                    taxation: taxations,
                    right: rights,
                    unit: units,
                    crop: crops,
                    isLoading: false
                });
            })
    }

    render() {
        const { classes } = this.props;

        return (
            <div className={classes.formInside}>
                <Card className={classes.card}>
                    <CardHeader
                        avatar={
                            <Avatar aria-label="Recipe" className={classes.avatar}>
                                {this.state.info.land_use}
                            </Avatar>
                        }
                        action={<IconButton> <MoreVertIcon /></IconButton>
                        }
                        title={this.state.info.land_use_descrip}
                        subheader={this.state.info.street_name}
                    />
                    <iframe style={{
                        width: '100%',
                        height: '350px',
                        frameborder: '0',
                        backgroundColor: '#000'
                    }} src={"https://www.google.com/maps/embed/v1/streetview?key=AIzaSyAnLaMgOf26IQLskTGRKSndq3NCpg8HPp0&location=" + this.state.info.latitude + "," + this.state.info.longitude + "&heading=210"}>
                    </iframe>
                    <CardContent>
                        <List component="nav">
                            <ListItem button className={classes.descriptions}>
                                <ListItemIcon >
                                    <BusinessIcon/>
                                </ListItemIcon>
                                <ListItemText inset primary={this.state.info.dimension_type_descrip} secondary={this.state.info.dimension_type} />
                            </ListItem>
                            <ListItem button className={classes.descriptions}>
                                <ListItemIcon>
                                    <FilterIcon/>
                                </ListItemIcon>
                                <ListItemText inset primary={this.state.info.area_type_descrip} secondary={this.state.info.area_type} />
                                <ListItemSecondaryAction>
                                    <Typography component="span">
                                        {this.state.info.area} m<sup>2</sup>
                                    </Typography>
                                </ListItemSecondaryAction>
                            </ListItem>
                        </List>
                    </CardContent>
                    <Divider />
                    <div className={classes.valuesContainer} justify="center">
                        <div className={classes.values} color='secondary'>
                            <Typography variant="caption" color='secondary'>Total Importe</Typography>
                            <br />
                            {this.state.info.total_amount} $
                            </div>
                        <div className={classes.values} >
                            <Typography variant="caption" color='secondary'>Total pagado</Typography>
                            <br />
                            {this.state.info.total_paid} $
                            </div>
                        <div className={classes.values}>
                            <Typography variant="caption" color='secondary'>% Pago</Typography>
                            <br />
                            {this.state.info.percent_paid} %
                            </div>
                    </div>
                    <Divider />
                    <div className={classes.otherInfo}>
                        <ExpansionPanel>
                            <ExpansionPanelSummary expandIcon={<ExpandMoreIcon />}>
                                <Typography className={classes.heading}>Valoración</Typography>
                            </ExpansionPanelSummary>
                            <ExpansionPanelDetails>
                                <List>
                                    {this.state.valuation}
                                </List>
                            </ExpansionPanelDetails>
                        </ExpansionPanel>
                        <ExpansionPanel>
                            <ExpansionPanelSummary expandIcon={<ExpandMoreIcon />}>
                                <Typography className={classes.heading}>Impuestos</Typography>
                            </ExpansionPanelSummary>
                            <ExpansionPanelDetails>
                                <List>
                                    {this.state.taxation}
                                </List>
                            </ExpansionPanelDetails>
                        </ExpansionPanel>
                        <ExpansionPanel>
                            <ExpansionPanelSummary expandIcon={<ExpandMoreIcon />}>
                                <Typography className={classes.heading}>Derechos</Typography>
                            </ExpansionPanelSummary>
                            <ExpansionPanelDetails>
                                <List>
                                    {this.state.right}
                                </List>
                            </ExpansionPanelDetails>
                        </ExpansionPanel>
                        <ExpansionPanel>
                            <ExpansionPanelSummary expandIcon={<ExpandMoreIcon />}>
                                <Typography className={classes.heading}>Cultivos</Typography>
                            </ExpansionPanelSummary>
                            <ExpansionPanelDetails>
                                <List>
                                    {this.state.crop}
                                </List>
                            </ExpansionPanelDetails>
                        </ExpansionPanel>
                        <ExpansionPanel>
                            <ExpansionPanelSummary expandIcon={<ExpandMoreIcon />}>
                                <Typography className={classes.heading}>Usos</Typography>
                            </ExpansionPanelSummary>
                            <ExpansionPanelDetails>
                                <List>
                                    {this.state.unit}
                                </List>
                            </ExpansionPanelDetails>
                        </ExpansionPanel>
                    </div>
                </Card>
            </div>
        )
    }
}

export default withStyles(styles)(DetailPage);