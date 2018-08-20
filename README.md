## \{gcM\} Gestión Catastral Multipaís
*Esta herramienta digital forma parte del catálogo de herramientas del **Banco Interamericano de Desarrollo**. Puedes conocer más sobre la iniciativa del BID en [code.iadb.org](code.iadb.org)*

<!-- COMO AÑADIR UNA IMAGEN: ![image Info](file:///F:/Documentos/Proyectos/BID/Github/Images/IBI.png "Descripción de la imagen")
-->


### Descripción y contexto
---

Esta plataforma que presentamos, denominada Plataforma de ***Gestión Catastral Multipaís*** está dirigida a aquellas entidades públicas que deseen disponer de una herramienta abierta de análisis, explotación e inspección de la información catastral en las múltiples áreas involucradas en una administración.

Como elemento diferenciador, hemos implementado, como modelo de datos subyacente, el modelo denominado **LADM** (*Land Administration Domain Model - ISO 19152*). Este modelo catastral está calificado como un estándar que se puede adaptar a las realidades de los modelos de datos catastrales básicos de diferentes paises, permitiendo extensiones que ajusten el modelo básico a las especificidades de cada país.

La evolución futura de esta plataforma irá en la línea de convertirse, además, en una herramienta de gestión integral de la información catastral, permitiendo la emisión de cédulas catastrales, enlazando con otros repositorios de datos como pueden ser la planeación, infraestructuras, etc., soportando los procesos de valoración, actualización continua del parcelario catastral, de la información física y jurídica de los inmuebles y propietarios y de la información necesaria para la gestión de cobros y contribuyentes del impuesto predial.

### Calendario y Ciclos de despliegue del Sistema ([ver documento de calendario](Calendario.pdf))
---
1.	**Funcionalidad Básica del Sistema (Versión 1). AGOSTO 2018**.
    - Implementación del Sistema Catastral multipaís con componentes de código abierto.
        - Funcionalidad para la Inclusión de mapas catastrales, parcelarios y ortofotografías.
        - Consultas de parcelas con los datos de dimensiones, valores catastrales, usos y otros.
        - Superposición de cartografía con mapas de catastro para mejorar la inspección tributaria.
        - Puesta a disposición de las municipalidades del Visor geográfico como herramienta de proyección del parcelario catastral.
     - Procesos disponibles para creación de capas y ficheros ‘.SLD’ para GeoServer.
     - Visor cliente para:
        - Consulta de predios seleccionando en el Mapa (ficha de predio).
        - Visor de Street View asociado a las parcelas catastrales.
        - Herramienta de selección de predios con proyección en el Mapa según filtros definibles.
        - Repositorio de temáticos catastrales predefinidos: Mapas de valor catastral; Mapas de usos prediales; Mapas por ratio de cobro del impuesto predial; Mapas de cultivos.
      - **PUEDE VERSE UNA DEMOSTRACIÓN DE LA HERRAMIENTA EN ESTE [LINK](https://sede.galileoiys.es/publico/territorio/catastro#)**
2.	**Funcionalidad Extendida. (Versión 2). DICIEMBRE 2018** (*).
    - Automatización con herramienta de carga de datos en formato estándar XML.
    - Modelos de intercambio de ficheros de mutaciones con autoridades catastrales nacionales.
    - Extensión de herramientas de análisis tributario.
    - Módulo de seguridad/auditoría.
    - Instalaciones locales y/o en la nube. Servicios de hospedaje.
    - Generación de cédulas/certificados catastrales. Consultas de predios.
    - Herramientas de GeoProcesamiento (selección por buffers, merge, etc.).
    - Generación recibos cobratorios, tipos impositivos y exenciones.
    - Integración con sistemas cobratorios municipales. Intercambio ficheros y domiciliaciones bancos.
3.	**Funcionalidad Extendida II (Versión 3). JULIO 2019** (*).
    - Extensión del modelo a otros repositorios de **_Catastro Multipropósito_**:
         - Integración con Registros de Propiedad y Notariados (y/u otras Entidades). 
         - Control de mutaciones catastrales. Pruebas con Blockchain.
         - Planeación, Infraestructuras y equipamiento municipal.
         - Catastro Rural.
    -  Desarrollo de la **_‘Oficina Virtual de Catastro’_** en línea para Consultas de ciudadanos, Tramitación de expedientes de mutaciones catastrales, Pagos telemáticos, Transparencia tributaria catastral.
    
(*) _Las funcionalidades extendidas pueden suponer costes de contratación._

### Guía de usuario
---
Explica los pasos básicos sobre cómo usar la herramienta digital. Es una buena sección para mostrar capturas de pantalla o gifs que ayuden a entender la herramienta digital.
 	
### Guía de instalación
---

En este apartado explicaremos la dependencias necesarias para construir la plataforma así como el procedimiento de instalación y puesta en marcha de la misma.

#### 1. Dependencias
Los componentes necesarios para poder desplegar la plataforma son los siguientes:
- **Microsoft Visual Studio Code** como entorno de desarrollo para programar la interfaz de cliente. Utilizar "_npm install_" para descargar e instalar todas las depencias del proyecto.
- **Microsoft Visual Studio 2017** para el desarrollo de la API de servicios web en el lado del servidor. El uso de la tecnología **ASP.net Core 2** permite la publicación en cualquier servidor de aplicaciones web, ya sea en Unix, Linux, Mac o Windows. 
- **PostgreSQL** 9.4, o superior, con extensión **PostGIS**, o bien **Oracle** 10.2 o superior con **Spatial Data Option** (SDO).
- **JDeveloper** 12.2, o superior.
- **Geoserver** 2.13, o superior, como servidor de mapas (publicación wms).
- **Leaflet** ver. 1.3 como visualizador de mapas. En el archivo "_LeafletPaje.js_" se encuentra la definición de las capas del mapa, que deberá editarse para ajustarlo a su configuración deseada.
- Recomendable utilizar la herramienta **"Atlas Styler"**, descargable de internet, para definir los estilos (ficheros .sld) de los mapas temáticos.

#### 2. Instalación de las Bases de Datos
En esta primera versión ofrecemos soporte para dos gestores de base de datos (PostgreSQL y Oracle). La instalación de los repositorios de datos puede ser llevada a cabo mediante la carga de scripts que pueden ser ejecutados desde herramientas específicas de las bases de datos como ***psql*** o ***SqlPlus***.

La instalación mediante scripts es un proceso manual menos automatizado, pero permite un mayor control del proceso de creación del repositorio de datos.

- __*Instalación en PostgreSQL.*__ 
> Los scripts necesarios para crear el repositorio están [aquí](/Databases/Postgres/) y deben ser ejecutados mediante ***psql***.
Leer el fichero ***Readme.txt*** para instrucciones detalladas sobre como llevar a cabo este proceso.

- __*Instalación en Oracle.*__ 
> Los scripts necesarios para crear el repositorio están [aquí](/Databases/Oracle/) y deben ser ejecutados mediante ***SqlPlus***.
Leer el fichero ***Readme.txt*** para instrucciones detalladas sobre como llevar a cabo este proceso.

#### 3. Instalación y configuración de GeoServer.
Para la descarga de Geoserver, lo primero es acudir a la página oficial del software libre http://geoserver.org/ y pinchar sobre la versión estable, identificada sobre un cuadro en color verde.

El siguiente paso será clicar sobre el sistema operativo que soporte nuestro equipo. Pinchamos sobre él para descargar el paquete de Geoserver. Una vez descargado, le damos a ejecutar y procederemos a la instalación siguiendo el asistente, e introduciendo los datos que se van pidiendo (directorio de datos, nombre de usuario y contraseña, puerto y otros).

En la carpeta '_Geoserver_' del repositorio dejamos ejemplos de cómo definir el 'html' de respuesta a una petición de información en el mapa. Incluimos un fichero "_content.ftl_", "_footer.ftl_" y "_header.ftl_" para su utilización.

#### 4. Instalación y configuración de la Web API.
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
#### 2. Visual Studio Core
Como se ha indicado, empleamos entorno de desarrollo Microsoft Visual Studio Core y ASP.net Core 2 para publicación.

#### 3. ¿XXXXXXXXXXXXXXXXXX?

### Código de conducta 
---
El código de conducta establece las normas sociales, reglas y responsabilidades que los individuos y organizaciones deben seguir al interactuar de alguna manera con la herramienta digital o su comunidad. 

Para más detalles, ver el documento [CODE-OF-CONDUCT.md](CODE-OF-CONDUCT.md). 

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
**Hemos preparado una [página web](https://sede.galileoiys.es/publico/territorio/catastro#) en la que se puede ver en operación la plataforma, así como obtener más información sobre el proyecto, líneas futuras de desarrollo, etc.**

Si lo desea, puede ver el [Resumen Ejecutivo](ResumenEjecutivo.pdf) para obtener información ampliada sobre el proyecto.

### Licencia 
---
El código fuente ha sido liberado bajo una licencia BSD. Para más detalles leer el documento [LICENSE.md](LICENSE.md).

### Limitación de responsabilidades
---

Galileo IyS no será responsable, bajo circunstancia alguna, de daño ni indemnización, moral o patrimonial; directo o indirecto; accesorio o especial; o por vía de consecuencia, previsto o imprevisto, que pudiese surgir:

1. Bajo cualquier teoría de responsabilidad, ya sea por contrato, infracción de derechos de propiedad intelectual, negligencia o bajo cualquier otra teoría; y/o
2. A raíz del uso de la Herramienta Digital, incluyendo, pero sin limitación de potenciales defectos en la Herramienta Digital, o la pérdida o inexactitud de los datos de cualquier tipo. Lo anterior incluye los gastos o daños asociados a fallas de comunicación y/o fallas de funcionamiento de computadoras, vinculados con la utilización de la Herramienta Digital.

