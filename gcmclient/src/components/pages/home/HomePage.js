import React from 'react';
import { withStyles } from '@material-ui/core/styles';
import Typography from '@material-ui/core/Typography';
import Grid from '@material-ui/core/Grid';
import Card from '@material-ui/core/Card';
import CardContent from '@material-ui/core/CardContent';
import CardMedia from '@material-ui/core/CardMedia';
import { Link } from 'react-router-dom'

const styles = theme => ({
    root: {
        flex: '1 0 100%',
        backgroundColor: theme.palette.background.paper,
    },
    hero: {
        minHeight: '80vh',
        flex: '0 0 auto',
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',

        color: theme.palette.type === 'light' ? theme.palette.primary.dark : theme.palette.primary.main,
    },
    text: {
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        justifyContent: 'center',
    },
    title: {
        letterSpacing: '.7rem',
        textIndent: '.7rem',
        fontWeight: theme.typography.fontWeightLight,
        [theme.breakpoints.only('xs')]: {
            fontSize: 28,
        },
        whiteSpace: 'nowrap',
    },
    headline: {
        paddingLeft: theme.spacing.unit * 4,
        paddingRight: theme.spacing.unit * 4,
        marginTop: theme.spacing.unit,
        maxWidth: 500,
        textAlign: 'center',
    },
    content: {
        paddingBottom: theme.spacing.unit * 8,
        paddingTop: theme.spacing.unit * 8,
        [theme.breakpoints.up('sm')]: {
            paddingTop: theme.spacing.unit * 12,
        },
    },
    startLink: {
        marginTop: 20,
        border: '1px solid rgba(63, 81, 181, 0.5)',
        padding: '8px 16px',
        color: '#3f51b5',
        textTransform: 'uppercase'
    },
    logo: {
        margin: `${theme.spacing.unit * 3}px 0 ${theme.spacing.unit * 4}px`,
        width: '100%',
        height: '75vw',
        maxHeight: 400,
    },
    steps: {
        maxWidth: theme.spacing.unit * 130,
        margin: 'auto',
    },
    step: {
        padding: `${theme.spacing.unit * 3}px ${theme.spacing.unit * 2}px`,
    },
    stepIcon: {
        marginBottom: theme.spacing.unit,
    },
    paper: {
        height: 240,
        width: 300,
    },
    control: {
        padding: theme.spacing.unit * 2,
    },
    card: {
        maxWidth: 345,
        minHeight: 400
    },
    media: {
        // ⚠️ object-fit is not supported by IE11.
        objectFit: 'cover',
        height: 120
    }
});

class HomePage extends React.Component {
    render() {
        const { classes } = this.props;

        return (
            <div className={classes.root}>
                <div className={classes.hero}>
                    <div className={classes.content}>
                        <img
                            src={require('./../../../assets/img/gcm1.png')}
                            alt="Material-UI Logo"
                            className={classes.logo}
                        />
                        <div className={classes.text}>
                            <Typography
                                variant="display2"
                                align="center"
                                component="h1"
                                color="inherit"
                                gutterBottom
                                className={classes.title}
                            >
                                {'GCM'}
                            </Typography>
                            <Typography
                                variant="headline"
                                component="h2"
                                color="inherit"
                                gutterBottom
                                className={classes.headline}
                            >
                                {"Gestión Catastral Multipais"}
                            </Typography>
                            <Link to={{ pathname: '/leaflet', state: { layer: 'Postgis:vw_spatial_unit' } }} className={classes.startLink} variant="outlined" color="primary">
                                {'Empezar'}
                            </Link>
                        </div>
                    </div>
                </div>

                <Grid container className={classes.root} spacing={16}>
                    <Grid item xs={12}>
                        <Grid container className={classes.demo} justify="center" spacing={Number(16)}>
                            <Grid item>
                                <Link to='/description'>
                                    <Card className={classes.card}>
                                        <CardMedia
                                            className={classes.media}
                                            image={require('./../../../assets/img/gcm4.jpg')}
                                            title="Contemplative Reptile"
                                        />
                                        <CardContent>
                                            <Typography gutterBottom variant="headline" component="h2">
                                                Descripción del Sistema
                                            </Typography>
                                            <Typography component="p">
                                                Averigue cuales son las principales ventajas de esta solución, sus posibles aplicaciones prácticas y la tecnología empleada.
                                            </Typography>
                                        </CardContent>
                                    </Card>
                                </Link>
                            </Grid>
                            <Grid item>
                                <Link to='/stages'>
                                    <Card className={classes.card}>
                                        <CardMedia
                                            className={classes.media}
                                            image={require('./../../../assets/img/gcm2.png')}
                                            title="Contemplative Reptile"
                                        />
                                        <CardContent>
                                            <Typography gutterBottom variant="headline" component="h2">
                                                Fases del proyecto
                                            </Typography>
                                            <Typography component="p">
                                                Conozca nuestro calendario de versiones previstas y esté informado en todo momento de la evolución del producto.
                                            </Typography>
                                        </CardContent>
                                    </Card>
                                </Link>
                            </Grid>
                            <Grid item>
                                <a href='https://github.com/GalileoIyS/-gcM-GESTION-CATASTRAL-MULTIPAIS#referencias'>
                                    <Card className={classes.card}>
                                        <CardMedia
                                            className={classes.media}
                                            image={require('./../../../assets/img/gcm4.jpg')}
                                            title="Contemplative Reptile"
                                        />
                                        <CardContent>
                                            <Typography gutterBottom variant="headline" component="h2">
                                                Casos de Éxito
                                            </Typography>
                                            <Typography component="p">
                                                Información sobre otros casos de éxito similares en el ámbito catastral.
                                            </Typography>
                                        </CardContent>
                                    </Card>
                                </a>
                            </Grid>
                        </Grid>
                    </Grid>
                </Grid>

            </div >
        )
    }
}

export default withStyles(styles, { withTheme: true })(HomePage);