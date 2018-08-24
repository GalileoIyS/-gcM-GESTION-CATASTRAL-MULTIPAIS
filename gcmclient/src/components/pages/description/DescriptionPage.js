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

class DescriptionPage extends React.Component {
    render() {
        const { classes } = this.props;

        return (
            <div className={classes.root}>
                <Typography variant="display2" gutterBottom>Descripción</Typography>
                <p>La Plataforma de Gestión Catastral multipaís está dirigida a aquellas entidades públicas que quieran hacer uso extenso y eficiente de la información catastral en las múltiples áreas involucradas en una administración.</p>
                <p>Permite el tratamiento, consulta y actualización continua de la información física y jurídica de inmuebles y propietarios, información de mapas del territorio y de información necesaria para la gestión de cobros y contribuyentes. Con todo ello, se plantea una plataforma que brinda la posibilidad de mejorar los niveles de control sobre la recaudación tributaria predial, y una herramienta que contribuya con eficacia a la toma de decisiones de gestión pública.</p>
                <p>Esta herramienta tecnológica, orientada al análisis y explotación de datos catastrales, está concebida como el núcleo de una plataforma que puede adaptarse a diferentes realidades jurídico-técnicas existentes en los países, así como escalar en funcionalidades ofertadas según demanda. Al mismo tiempo la plataforma permitirá la integración con otros desarrollos, propios o de terceros, que permitan evolucionar la cantidad de servicios ofrecidos, así como garantizar la creación de valor para la región mediante modelos que se basen en la co-creación de servicios específicos adicionales a la plataforma.</p>
                <p>El objetivo es ofrecer una plataforma de código abierto y software libre con funcionalidades catastrales básicas que pueda ser puesta en operación de forma rápida, y que permita adaptarse a la realidad de diferentes países en cuanto a sus distintas especificaciones de modelos de datos catastrales básicos o, por supuesto, a funcionalidades específicas.</p>
                <Typography variant="display1" gutterBottom>Modelo Catastral</Typography>
                <p>El modelo que en estos momentos cumple este requisito es, sin duda, el <strong>LADM (Land Administration Domain Model)</strong> que se ha convertido en un estándar internacional, avalado por su aprobación como norma ISO 19152, de modelo conceptual catastral para la administración de tierras.</p>
                <Typography variant="display1" gutterBottom>Base de Datos</Typography>
                <p>Como parte de la infraestructura de software básica nos apoyamos en un gestor de base de datos relacional que nos permita almacenar y extraer la información gestionada por la plataforma. Optaremos por <strong>PostgreSQL con extensión PostGIS</strong> como repositorio de datos de la solución.</p>
                <p>Dada la amplia difusión de Oracle como base de datos en Sudamérica, también ofrecemos la posibilidad de llevar a cabo el despliegue de la herramienta sobre ella siempre y cuando se disponga de una versión con la extensión espacial Oracle SDO instalada y operativa.</p>
                <Typography variant="display1" gutterBottom>Servidor de Mapas</Typography>
                <p>El servidor de mapas debe implementar la posibilidad de publicar servicios de mapas de los predios bajo las especificaciones definidas por el <strong>OGC (Open Geospatial Consortium)</strong> como por ejemplo WMS, WCS o WFS. Asimismo, será capaz de consumir este tipo de servicios publicados por otras entidades bajo el paradigma de nodos IDE.</p>
                <p>En cuanto a los componentes de base utilizados para implementar este servidor de mapas, hemos utilizado GeoServer, cuya licencia es de libre distribución sin restricciones y soporta los servicios de mapa requeridos así como el WFS-T (Transaccional) necesario para la evolución futura de la herramienta a una plataforma de mantenimiento de datos catastrales.</p>
                <Typography variant="display1" gutterBottom>Modelo de desarrollo de la solución</Typography>
                <p>El desarrollo de la solución se ejecuta mediante la implementación de versiones, y se lleva a cabo siguiendo un patrón de arquitectura de software reconocida en la comunidad de software libre y de suficiente garantía de calidad y evolución. Por ello seleccionamos el <strong>Modelo Vista Controlador (MVC)</strong> como la mejor opción para la arquitectura del sistema, separando la lógica de negocio de la interfaz de usuario y del repositorio de datos subyacente. </p>
            </div>
        );
    }
}

export default withStyles(styles, { withTheme: true })(DescriptionPage);