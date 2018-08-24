import React from 'react';
import { withStyles } from '@material-ui/core/styles';
import Typography from '@material-ui/core/Typography';

const styles = theme => ({
    root: {
        paddingTop: 80,
        paddingLeft: 50,
        paddingRight: 50
    },
});

class StagePage extends React.Component {
    render() {
        const { classes } = this.props;

        return (
            <div className={classes.root}>
                <Typography variant="display2" gutterBottom>Calendario y ciclos de despliegue</Typography>
                <p>Galileo Ingeniería y Servicios informa que el sistema Catastral Multipaís para municipalidades de América latina se ha desplegado en código abierto y las instrucciones de instalación en GITHUB en agosto de 2018, con la correspondiente documentación y enlaces, así como una página web de demostración y las guías de instalación.</p>
                <p>Está previsto habilitar durante todo el mes de septiembre un servicio de apoyo de soporte gratuito para instalación de la herramienta, cuya experiencia se aprovechará para mejorar la gía de instalación con las preguntas más frecuentes. </p>
                <Typography variant="display1">Funcionalidad Básica del Sistema (Versión 1).</Typography>
                <Typography variant="caption" gutterBottom color='primary'>Agosto 2018</Typography>
                <ul>
                    <li>Implementación del Sistema Catastral multipaís con componentes de código abierto.
                        <ul>
                            <li>Funcionalidad para la Inclusión de mapas catastrales, parcelarios y ortofotografías.</li>
                            <li>Consultas de parcelas con los datos de dimensiones, valores catastrales, usos y otros.</li>
                            <li>Superposición de cartografía con mapas de catastro para mejorar la inspección tributaria.</li>
                            <li>Puesta a disposición de las municipalidades del Visor geográfico como herramienta de proyección del parcelario catastral.</li>
                        </ul>
                    </li>
                    <li>Procesos disponibles para creación de capas y ficheros .sld para GeoServer.</li>
                    <li>Visor cliente para.
                        <ul>
                            <li>Consulta de predios seleccionando en el Mapa (ficha de predio).</li>
                            <li>Visor de Streat View asociado a las parcelas catastrales.</li>
                            <li>Herramienta de selección de predios con proyección en el Mapa según filtros definibles.</li>
                            <li>Repositorio de temáticos catastrales predefinidos
                                <ul>
                                    <li>Mapas de valor catastral.</li>
                                    <li>Mapas de usos prediales.</li>
                                    <li>Mapas por importe del impuesto predial.</li>
                                </ul>
                            </li>
                        </ul>
                    </li>
                </ul>
                <Typography variant="display1">Funcionalidad Extendida (Versión 2)</Typography>
                <Typography variant="caption" gutterBottom color='primary'>Diciembre 2018</Typography>
                <ul>
                    <li>Automatización con herramienta de carga de datos en formato estándar  XML.</li>
                    <li>Modelos de intercambio de ficheros de mutaciones con autoridades catastrales nacionales.</li>
                    <li>Extensión de herramientas de análisis tributario.</li>
                    <li>Módulo de seguridad/auditoría.</li>
                    <li>Instalaciones locales y/o en la nube. Servicios de hospedaje.</li>
                    <li>Generación de cédulas/certificados catastrales. Consultas de predios.</li>
                    <li>Herramientas de GeoProcesamiento (selección por buffers, merge, etc.).</li>
                    <li>Generación recibos cobratorios, tipos impositivos y exenciones.</li>
                    <li>Integración con sistemas cobratorios municipales. Intercambio ficheros y domiciliaciones bancos.</li>
                </ul>
                <Typography variant="display1">Funcionalidad Extendida (Versión 3)</Typography>
                <Typography variant="caption" gutterBottom color='primary'>Julio 2019</Typography>
                <ul>
                    <li>Extensión del modelo a otros repositorios de Catastro Multipropósito:
                        <ul>
                            <li>Integración con Registros de Propiedad y Notariados (y/u otras Entidades). </li>
                            <li>Control de mutaciones catastrales. Pruebas con Blockchain</li>
                            <li>Planeación, Infraestructuras y equipamiento municipal.</li>
                            <li>Catastro Rural.</li>
                        </ul>
                    </li>
                    <li>o	Desarrollo de la ‘Oficina Virtual de Catastro’ en línea para Consultas de ciudadanos, Tramitación de expedientes de mutaciones catastrales, Pagos telemáticos, Transparencia tributaria catastral,...</li>
                </ul>
            </div>
        )
    }
}

export default withStyles(styles, { withTheme: true })(StagePage);