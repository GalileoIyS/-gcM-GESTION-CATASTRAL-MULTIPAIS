## \{gcM\} Gestión Catastral Multipaís
*Esta herramienta digital forma parte del catálogo de herramientas del **Banco Interamericano de Desarrollo**. Puedes conocer más sobre la iniciativa del BID en [code.iadb.org](code.iadb.org)*

<!-- COMO AÑADIR UNA IMAGEN: ![image Info](file:///F:/Documentos/Proyectos/BID/Github/Images/IBI.png "Descripción de la imagen")
-->


### Descripción y contexto
---

Esta plataforma que presentamos, denominada Plataforma de ***Gestión Catastral Multipaís*** está dirigida a aquellas entidades públicas que deseen disponer de una herramienta abierta de análisis, explotación e inspección de la información catastral en las múltiples áreas involucradas en una administración.

Como elemento diferenciador, hemos implementado, como modelo de datos subyacente, el modelo denominado **LADM** (*Land Administration Domain Model - ISO 19152*). Este modelo catastral está calificado como un estándar que se puede adaptar a las realidades de los modelos de datos catastrales básicos de diferentes paises, permitiendo extensiones que ajusten el modelo básico a las especificidades de cada país.

La evolución futura de esta plataforma irá en la línea de convertirse, además, en una herramienta de gestión integral de la información catastral, permitiendo la emisión de cédulas catastrales, enlazando con otros repositorios de datos como pueden ser la planeación, infraestructuras, etc., soportando los procesos de valoración, actualización continua del parcelario catastral, de la información física y jurídica de los inmuebles y propietarios y de la información necesaria para la gestión de cobros y contribuyentes del impuesto predial.

### Calendario y Ciclos de despliegue del Sistema
---
1.	**Publicación en Github. MAYO 2018**.
    - Descripción y documentación de la herramienta.
    - Guía de Instalación y Requerimientos. 
    - Enlace a la Plataforma de demostración a usuarios (ejemplos y pruebas).
2.	**Servicios de Consultoría e Implantación. JULIO 2018**.
    - Consultoría/diseño de extensiones del modelo base LADM a la problemática específica de cada país.
    - Apoyo a la implantación y carga inicial de datos de la herramienta.
    - Formación.
    - Desarrollos ad-hoc según demanda.
    - Descripción y documentación de la herramienta.
3.	**Funcionalidad Básica del Sistema (Versión 1). AGOSTO 2018**.
    - Implementación del modelo LADM en base de datos Oracle y Postgre/Postgis.
    - Inclusión de modelo extendido de datos de cobro del impuesto predial que permitan mejorar la recaudación tributaria predial.
    - Visor geográfico como herramienta de proyección del parcelario catastral:
         - a)Creación de capas y ficheros "_.SLD_" para Geoserver.
         - b)Visor cliente utilizando Leaflet.
    - Consulta de predios seleccionando en el Mapa (ficha de predio).
    - Herramienta de selección de predios con proyección en el Mapa según filtros definibles por el usuario.
    - Repositorio de temáticos predefinidos:
         - c)Mapas de valor catastral.
         - d)Mapas de usos prediales.
         - e)Mapas por importe del impuesto predial.
**PUEDE VERSE UNA DEMOSTRACIÓN DE LA HERRAMIENTA EN ESTE [LINK](https://sede.galileoiys.es/publico/territorio/catastro#)**
4.	**Funcionalidad Extendida. (Versión 2). DICIEMBRE 2018**
    - Herramienta de carga de datos en el modelo sobre formato XML.
    - Extensión de herramientas de análisis tributario.
    - Módulo de seguridad/auditoría.
    - Instalaciones locales y/o en la nube. Servicios de hospedaje.
    - Generación de cédulas/certificados catastrales.
    - Herramientas de GeoProcesamiento (selección por buffers, merge, etc.).
    - Generación recibos cobratorios, tipos impositivos y exenciones.
    - Integración con sistemas cobratorios municipales. Intercambio ficheros y domiciliaciones bancos.
5.	**Funcionalidad Extendida II (Versión 3). JULIO 2019**
    - Extensión del modelo a otros repositorios de Catastro Multipropósito:
         - a)Integración con Registros de Propiedad y Notariados (y/u otras Entidades).
         - b)Planeación, Infraestructuras y equipamiento municipal.
         - c)Catastro Rural.
    - Desarrollo de la ‘_Oficina Virtual de Catastro_’ para Consultas de ciudadanos, Tramitación de expedientes de mutaciones catastrales, Pagos telemáticos, Transparencia tributaria catastral.


### Guía de usuario
---
Explica los pasos básicos sobre cómo usar la herramienta digital. Es una buena sección para mostrar capturas de pantalla o gifs que ayuden a entender la herramienta digital.
 	
### Guía de instalación
---

En este apartado explicaremos la dependencias necesarias para construir la plataforma así como el procedimiento de instalación y puesta en marcha de la misma.

#### 1. Dependencias
Los componentes necesarios para poder desplegar la plataforma son los siguientes:
- Entorno de desarrollo **Microsoft Visual Studio Core**.
- **ASP.net Core 2** (para ser publicado en servidores de aplicaciones en Unix, Linux, Ios y Windows). Utilizar "_npm install_" para descargar todas las depencias del proyecto.
- **PostgreSQL** 9.4, o superior, con extensión **PostGIS**, o bien **Oracle** 10.2 o superior con **Spatial Data Option** (SDO).
- **JDeveloper** 12.2, o superior.
- **Geoserver** 2.13, o superior, como servidor de mapas (publicación wms).
- **Leaflet** ver. 1.3 como visualizador de mapas. En el archivo "_LeafletPaje.js_" se encuentra la definición de las capas del mapa, que deberá editarse para ajustarlo a su configuración deseada.
- Recomendable utilizar la herramienta **"Atlas Styler"**, descargable de internet, para definir los estilos (ficheros .sld) de los mapas temáticos.
- **¿¿Servidor Web IIS ver. 8 o superior.??**

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

#### 4. Instalación y configuración del Website.


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

### Autor/es
---
* Juan Antonio Ubalde <jubalde@galileoiys.es>
* Gregorio Martín <gmartin@galileoiys.es>
* Domingo Rodríguez <drodriguez@galileoiys.es>
* Nicolás Hernández <nhernandez@galileoiys.es>

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

