import React from 'react';
import PropTypes from 'prop-types';
import classNames from 'classnames';
import { Switch, Route } from 'react-router-dom'
import { withStyles } from '@material-ui/core/styles';
import Drawer from '@material-ui/core/Drawer';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import List from '@material-ui/core/List';
import { Link } from 'react-router-dom'
import Typography from '@material-ui/core/Typography';
import Divider from '@material-ui/core/Divider';
import IconButton from '@material-ui/core/IconButton';
import MenuIcon from '@material-ui/icons/Menu';
import ChevronLeftIcon from '@material-ui/icons/ChevronLeft';
import ChevronRightIcon from '@material-ui/icons/ChevronRight';
import LocationCityIcon from '@material-ui/icons/LocationCity';
import AirlineSeatFlatIcon from '@material-ui/icons/AirlineSeatFlat';
import LocalFloristIcon from '@material-ui/icons/LocalFlorist';
import HowToVoteIcon from '@material-ui/icons/HowToVote';
import ListItem from '@material-ui/core/ListItem';
import ListItemIcon from '@material-ui/core/ListItemIcon';
import ListItemText from '@material-ui/core/ListItemText';
import HomeIcon from '@material-ui/icons/Home';
import LastPageIcon from '@material-ui/icons/LastPage';
import FirstPageIcon from '@material-ui/icons/FirstPage';
import FormatListNumberedIcon from '@material-ui/icons/FormatListNumbered';
import MoneyIcon from '@material-ui/icons/Money';
import FormatAlignJustifyIcon from '@material-ui/icons/FormatAlignJustify';
import GithubIcon from '@material-ui/icons/FirstPage';
import Tooltip from '@material-ui/core/Tooltip';

import Home from '../pages/home/HomePage';
import Description from '../pages/description/DescriptionPage';
import Stage from '../pages/stages/StagePage';
import Leaflet from '../pages/leaflet/LealfetPage';
import Detail from '../pages/detail/DetailPage';


const drawerWidth = 240;

const styles = theme => ({
    root: {
        flexGrow: 1,
    },
    appFrame: {
        zIndex: 1,
        overflow: 'hidden',
        position: 'relative',
        display: 'flex',
        width: '100%',
    },
    appBar: {
        position: 'absolute',
        transition: theme.transitions.create(['margin', 'width'], {
            easing: theme.transitions.easing.sharp,
            duration: theme.transitions.duration.leavingScreen,
        }),
    },
    appBarShift: {
        width: `calc(100% - ${drawerWidth}px)`,
        transition: theme.transitions.create(['margin', 'width'], {
            easing: theme.transitions.easing.easeOut,
            duration: theme.transitions.duration.enteringScreen,
        }),
    },
    linkmenu: {
        TextDecoration: 'none'
    },
    'appBarShift-left': {
        marginLeft: drawerWidth,
    },
    'appBarShift-right': {
        marginRight: drawerWidth,
    },
    menuButton: {
        marginLeft: 12,
        marginRight: 20,
    },
    hide: {
        display: 'none',
    },
    drawerPaper: {
        position: 'relative',
        width: drawerWidth,
    },
    drawerHeader: {
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'flex-start',
        padding: '0 8px',
        ...theme.mixins.toolbar,
    },
    drawerHeaderArrow: {
        marginLeft: 'auto'
    },
    anchorButton: {
        marginLeft: 'auto'
    },
    content: {
        flexGrow: 1,
        backgroundColor: theme.palette.background.default,
        padding: theme.spacing.unit * 0,
        transition: theme.transitions.create('margin', {
            easing: theme.transitions.easing.sharp,
            duration: theme.transitions.duration.leavingScreen,
        }),
    },
    'content-left': {
        marginLeft: -drawerWidth,
    },
    'content-right': {
        marginRight: -drawerWidth,
    },
    contentShift: {
        transition: theme.transitions.create('margin', {
            easing: theme.transitions.easing.easeOut,
            duration: theme.transitions.duration.enteringScreen,
        }),
    },
    'contentShift-left': {
        marginLeft: 0,
    },
    'contentShift-right': {
        marginRight: 0,
    },
});

class MainPage extends React.Component {
    state = {
        open: false,
        anchor: 'left'
    };

    handleDrawerOpen = () => {
        this.setState({ open: true });
    };

    handleDrawerClose = () => {
        this.setState({ open: false });
    };

    handleChangeAnchor = event => {
        if (this.state.anchor === 'left')
            this.setState({ anchor: 'right' });
        else
            this.setState({ anchor: 'left' });
    };

    handleMenu = event => {
        this.setState({ anchorEl: event.currentTarget });
    };


    render() {
        const { classes, theme } = this.props;
        const { anchor, open } = this.state;

        const drawer = (
            <Drawer variant="persistent" anchor={anchor} open={open} classes={{ paper: classes.drawerPaper }}>
                <div className={classes.drawerHeader}>
                    <Typography variant="title" align="left">
                        GCM
                    </Typography>
                    <IconButton onClick={this.handleDrawerClose} className={classes.drawerHeaderArrow}>
                        {theme.direction === 'rtl' ? <ChevronRightIcon /> : <ChevronLeftIcon />}
                    </IconButton>
                </div>
                <Divider />
                <List>
                    <ListItem button>
                        <ListItemIcon>
                            <HomeIcon />
                        </ListItemIcon>
                        <Link to='/'>
                            <ListItemText primary="Inicio" />
                        </Link>
                    </ListItem>
                    <ListItem button>
                        <ListItemIcon>
                            <FormatAlignJustifyIcon />
                        </ListItemIcon>
                        <Link to='/description'>
                            <ListItemText primary="Descripción" />
                        </Link>
                    </ListItem>
                    <ListItem button>
                        <ListItemIcon>
                            <FormatListNumberedIcon />
                        </ListItemIcon>
                        <Link to='/stages'>
                            <ListItemText primary="Fases del proyecto" />
                        </Link>
                    </ListItem>
                    <Divider />
                    <ListItem button>
                        <ListItemIcon>
                            <LocationCityIcon />
                        </ListItemIcon>
                        <Link className={classes.linkmenu} to={{ pathname: '/leaflet', state: { layer: 'Postgis:vw_spatial_unit' } }}>
                            <ListItemText primary="Catastro" />
                        </Link>
                    </ListItem>
                    <ListItem button>
                        <ListItemIcon>
                            <AirlineSeatFlatIcon />
                        </ListItemIcon>
                        <Link className={classes.linkmenu} to={{ pathname: '/leaflet', state: { layer: 'Postgis:vw_spatial_unit_uso' } }}>
                            <ListItemText primary="Uso del suelo" />
                        </Link>
                    </ListItem>
                    <ListItem button>
                        <ListItemIcon>
                            <HowToVoteIcon />
                        </ListItemIcon>
                        <Link className={classes.linkmenu} to={{ pathname: '/leaflet', state: { layer: 'Postgis:vw_spatial_unit_cobro' } }}>
                            <ListItemText primary="% Cobro" />
                        </Link>
                    </ListItem>
                    <ListItem button>
                        <ListItemIcon>
                            <LocalFloristIcon />
                        </ListItemIcon>
                        <Link className={classes.linkmenu} to={{ pathname: '/leaflet', state: { layer: 'Postgis:vw_spatial_unit_cultivos' } }}>
                            <ListItemText primary="Cultivos" />
                        </Link>
                    </ListItem>
                    <ListItem button>
                        <ListItemIcon>
                            <MoneyIcon />
                        </ListItemIcon>
                        <Link className={classes.linkmenu} to={{ pathname: '/leaflet', state: { layer: 'Postgis:vw_spatial_unit_valor_cat' } }}>
                            <ListItemText primary="Valor Catastral" />
                        </Link>
                    </ListItem>
                </List>
            </Drawer>
        );

        let before = null;
        let after = null;

        if (anchor === 'left') {
            before = drawer;
        } else {
            after = drawer;
        }

        return (
            <div className={classes.root}>
                <div className={classes.appFrame}>
                    <AppBar
                        className={classNames(classes.appBar, {
                            [classes.appBarShift]: open,
                            [classes[`appBarShift-${anchor}`]]: open,
                        })}>
                        <Toolbar disableGutters={!open}>
                            <IconButton
                                color="inherit"
                                aria-label="Open drawer"
                                onClick={this.handleDrawerOpen}
                                className={classNames(classes.menuButton, open && classes.hide)}>
                                <MenuIcon />
                            </IconButton>
                            <Typography variant="title" color="inherit" noWrap>Gestión Catastral Multipaís</Typography>
                            <IconButton onClick={this.handleChangeAnchor} color="inherit" className={classes.anchorButton}>
                                {this.state.anchor === 'left' ? <LastPageIcon /> : <FirstPageIcon />}
                            </IconButton>
                            <Tooltip title="GitHub repository" enterDelay={300}>
                                <IconButton
                                    component="a"
                                    color="inherit"
                                    href="https://github.com/mui-org/material-ui"
                                    aria-label="GitHub repository">
                                    <GithubIcon />
                                </IconButton>
                            </Tooltip>
                        </Toolbar>
                    </AppBar>
                    {before}
                    <main className={classNames(classes.content, classes[`content-${anchor}`], { [classes.contentShift]: open, [classes[`contentShift-${anchor}`]]: open })}>
                        <Switch>
                            <Route exact path='/' component={Home} />
                            <Route path='/description' component={Description} />
                            <Route path='/stages' component={Stage} />
                            <Route path='/leaflet' component={Leaflet} />
                            <Route path='/detalle' component={Detail} />
                        </Switch>
                    </main>
                    {after}
                </div>
            </div>
        );
    }
}

MainPage.propTypes = {
    classes: PropTypes.object.isRequired,
    theme: PropTypes.object.isRequired,
};

export default withStyles(styles, { withTheme: true })(MainPage);