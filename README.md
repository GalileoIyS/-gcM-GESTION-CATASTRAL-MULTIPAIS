## Gestión Catastral Multipaís \{gcM\} 

[![Build Status](https://www.travis-ci.org/GalileoIyS/-gcM-GESTION-CATASTRAL-MULTIPAIS.svg?branch=master)](https://www.travis-ci.org/GalileoIyS/-gcM-GESTION-CATASTRAL-MULTIPAIS)
![](https://img.shields.io/badge/license-BSD-blue.svg)

*Esta herramienta digital forma parte del catálogo de herramientas del **Banco Interamericano de Desarrollo** [code.iadb.org](code.iadb.org)*.

La Plataforma **Gestión Catastral Multipaís** permite el tratamiento, consulta y actualización continua de la información catastral de un territorio. Con esta herramienta, funcionarios de las administraciones públicas pueden gestionar los tributos que afectan a la mayor fuente de ingresos de administraciones territoriales y conectarlo con diferentes áreas de la administración. (Ver demo en http://gcmclient.galileoiys.es/)

> **gcM gestiona la información necesaria para la gestión de cobros y contribuyentes. (Información física y jurídica de inmuebles y propietarios, información de mapas del territorio y de información)**

*¿Y por qué Multipaís?*
gcM está implementado con el modelo de datos territoriales denominado **LADM** (*Land Administration Domain Model - ISO 19152*). Este modelo catastral está calificado como un estándar que se puede adaptar a las realidades de los modelos de datos de diferentes paises, permitiendo que gcM se pueda ajustar a las especificidades de cada país.

**Esta herramienta ha sido desarrollada por [Galileo Ingeniería y Servicios](http://www.galileoiys.com/), especializada en la gestión electrónica de las administraciones públicas.**

### Funcionalidades
---
**Versión 1**
- Instalación y configuración de bases de datos
- Consulta de parcelas y datos de valores catastrales, usos y otros
- Visor Street View asociado a parcela catastral

**Versión 2** [Prevista para Diciembre 2018] - **Contactar para más información.**
- Automatización de la carga de datos en formato XML 
- Herramienta de análisis tributario
- Generación de cédulas y certificados catastrales
- Modelo de intercambio de ficheros de datos con autoridades catastrales nacionales
- Generación de recibos cobratorios, tipos impositivos y exenciones
- Integración con sistemas cobratorios municipales - (Ver otros productos de Galileo para [más información](http://www.galileoiys.es/productos-3/)) 
- Servicios de hospedaje local/en la nube

**Versión 3** [Prevista para Julio 2019]
- Integración con registro de propiedad y notariados (y otras entidades)
- Control de mutaciones catastrales (pruebas con Blockchain)
- Planeación, infraestructuras y equipamiento municipal
- Catastro rural
- Desarrollo de la **Oficina Virtual de Catastro** en línea para consultas de ciudadanos, tramitación de expedientes, pagos telemáticos, y transparencia tributaria.

### Guía de instalación
---
Se ofrece soporte para la instalación y configuración de la herramienta. Contactar a galileo@galileoiys.es para más información.

#### 1. Prerequisitos

- **Microsoft Visual Studio Code** Utilizar "_npm install_" para descargar e instalar todas las depencias del proyecto.
- **Microsoft Visual Studio 2017** 
- **PostgreSQL** (9.4, o superior, con extensión PostGIS), o bien **Oracle** (10.2 o superior con Spatial Data Option (SDO))
- **JDeveloper** 12.2, o superior.
- **Geoserver** 2.13, o superior, como servidor de mapas (publicación wms).
- **Leaflet** (versión 1.3). El archivo "_LeafletPaje.js_" se encuentra la definición de las capas del mapa, que deberá editarse para ajustarlo a su configuración deseada.
- Recomendado: **"Atlas Styler"**, para definir los estilos (ficheros .sld) de los mapas temáticos.

#### 2. Instalación de las Bases de Datos
Soporte para PostgreSQL y Oracle). Contactar con desarrolladores para configuración con otras bases de datos. 

Para instalar las bases de datos es necesario cargar los scripts en las herramientas específicas de las bases de datos como ***psql*** o ***SqlPlus***.

- Instalación en PostgreSQL
> Scripts [aquí](/Databases/Postgres/). Ejecutar mediante ***psql***. El fichero [Readme.txt](https://github.com/GalileoIyS/-gcM-GESTION-CATASTRAL-MULTIPAIS/tree/master/Databases/Postgres) contiene las instrucciones específicas.

- Instalación en Oracle
> Scripts [aquí](/Databases/Oracle/). Ejecutar mediante ***SqlPlus***. El fichero [Readme.txt](https://github.com/GalileoIyS/-gcM-GESTION-CATASTRAL-MULTIPAIS/tree/master/Databases/Oracle) contiene las instrucciones específicas.

#### 3. Instalación y configuración de GeoServer.
Descargar e instalar [Geoserver](http://geoserver.org/) para la versión de tu sistema operativo.

En la carpeta '_Geoserver_' del repositorio dejamos ejemplos de cómo definir el 'html' de respuesta a una petición de información en el mapa. Incluimos un fichero "_content.ftl_", "_footer.ftl_" y "_header.ftl_" para su utilización.

#### 4. Instalación y configuración de la REST Web API.
Abrir mediante Visual Studio 2017 la solución **GCMServer** compuesta por dos proyectos: 
- **GCMClases**: Librería desarrollada en Visual Basic .Net para construir la capa de conexión a la Base de Datos.
- **GCMServer**: Proyecto c# en ASP.Net Core 2 para la definición de los diferentes controladores y acciones que formaran parte de la API pública.

En este último proyecto, encontraremos un fichero de configuración llamado **app.config** donde deberemos configurar la cadena de conexión correcta hacia nuestra base de datos PostgreSQL.

#### 5. Instalación y configuración del cliente web.
Abrir mediante Visual Studio Core la solución **GCMClient** y posteriormente ejecutar el comando "_npm install --save_" para descargar e instalar todas las librerías secundarias necesarias. Para hacer esto, es necesario comprobar que tenemos instalado una versión reciente del paquete ["_node.js_"](https://nodejs.org/es/) y el gestor de paquetes de código javascript ["_npm_"](https://www.npmjs.com/).

Una vez instalado, podemos ejecutarlo mediante el comando "_npm start_" en el terminal integrado que viene con Visual Studio Code.

### Desarrollo
---
Los componentes necesarios para desarrollar son los siguientes:
#### 1. JDeveloper 12.2
Hemos utilizado JDeveloper 12.2, con la función Desarrollador de bases de datos, para diseñar el repositorio.
El espacio de trabajo de diseño se encuentra en **Modelo LADM \ DBModelling**.
#### 2. Visual Studio 2017
Empleamos el entorno de desarrollo Microsoft Visual Studio 2017 con ASP.net Core 2 para el desarrollo de los servicios web en el lado del servidor. Dentro de esta solución, encontraremos dos proyectos. Uno de ellos escrito en el lenguaje de programación Visual Basic.Net para las librerías de clases que definen la conexión con la base de datos y otro proyecto en lenguaje C# para el código de los controladores y acciones de los diferentes servicios web.

El código de ambos proyectos estan disponibles dentro de los directorios /gcmclases/GCMClases** y /gcmserver.

#### 3. Visual Studio Code
Empleamos el entorno de desarrollo Microsoft Visual Studio Code para el desarrollo de la interfaz de cliente. Para ello, se ha utilizado el framework de javascript conocido como **React** junto con el estilo **material** para construir la interfaz del cliente siguiendo un patrón de diseño SPA (Single Page Application). Ver código en el directorio /gcmclient.

### Código de conducta 
---
[CODE-OF-CONDUCT.md](CODE-OF-CONDUCT.md). 

### Autoría
---
* **Galileo Ingeniería y Servicios, S.A. https://www.galileoiys.es/**
* Juan Antonio Ubalde <jubalde@galileoiys.es>
* Gregorio Martín <gmartin@galileoiys.es>
* Domingo Rodríguez <drodriguez@galileoiys.es>
* Nicolás Hernández <nhernandez@galileoiys.es>

### Referencias
---
* [Sistema de Gestión Catastral Galileo](http://www.galileoiys.es/portfolio-item/gestion-catastral/)
* [Sede Electrónica Gestión Tributaria y Territorio](https://sede.galileoiys.es/publico/territorio/catastro#)
* [Sede Electrónica Tuluá](http://tulua.galileoiys.es/)
* [Vídeo demostrativo Sistema de Gestión Catastral](https://www.youtube.com/watch?v=DFPdrn-bul8)
* [Vídeo demostrativo Sistema Catastral Tuluá](https://youtu.be/DFPdrn-bul8)
* [SIELOCAL, Portal de Transparencia Económica de entidades públicas](http://www.sielocal.com/)
* [Vídeo demostrativo SIELOCAL](https://www.youtube.com/watch?v=bDRYJ1C8Ir4)

### Información Adicional / DEMOSTRACIÓN
---
[Resumen Ejecutivo](ResumenEjecutivo.pdf) para obtener información ampliada sobre el proyecto.

La visión de la plataforma es ser una herramienta de gestión integral de la información catastral, permitiendo la emisión de cédulas catastrales, enlazando con otros repositorios de datos como pueden ser la planeación, infraestructuras, etc., soportando los procesos de valoración, actualización continua del parcelario catastral, de la información física y jurídica de los inmuebles y propietarios y de la información necesaria para la gestión de cobros y contribuyentes del impuesto predial.

Ver calendario y ciclos de despliegue del Sistema en el ([calendario](Calendario.pdf))

### Licencia 
---
[Licencia BSD](LICENSE.md).

### Limitación de responsabilidades
---

Galileo IyS no será responsable, bajo circunstancia alguna, de daño ni indemnización, moral o patrimonial; directo o indirecto; accesorio o especial; o por vía de consecuencia, previsto o imprevisto, que pudiese surgir:

1. Bajo cualquier teoría de responsabilidad, ya sea por contrato, infracción de derechos de propiedad intelectual, negligencia o bajo cualquier otra teoría; y/o
2. A raíz del uso de la Herramienta Digital, incluyendo, pero sin limitación de potenciales defectos en la Herramienta Digital, o la pérdida o inexactitud de los datos de cualquier tipo. Lo anterior incluye los gastos o daños asociados a fallas de comunicación y/o fallas de funcionamiento de computadoras, vinculados con la utilización de la Herramienta Digital.

> **Mejorar los niveles de control sobre la recaudación tributaria predial, permite el desarrollo económico y social de los territorios.**
