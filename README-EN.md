*This software is part of the tools catalog of the **Inter-American Development Bank**. You can learn more about this IADB initiative at [code.iadb.org](code.iadb.org)*.

## \{gcM\} Gestión Catastral Multipaís

### Description and Context
---
This platform that we present, called ***Multi-country Cadastral Platform*** is aimed at those public entities wishing to have an open tool for analysis, exploitation and inspection of cadastral information in the multiple areas that are involved in public administrations.

As a differentiating element, we have implemented, as the underlying data model, the **LADM** (*Land Administration Domain Model - ISO 19152*). This cadastral model is qualified as a standard that can be adapted to the different cadastral realities of countries, allowing extensions that adjust the basic model to the specificities of each country.

Future evolution of this platform will go in the line of becoming a tool for the fully management of cadastral information, allowing the issuance of cadastral certificates, linking with other data repositories such as planning, infrastructures, etc, supporting the valuation processes, continuous update of cadastral parcels, physical and legal information of land properties and owners and of the information necessary to manage the payments of property taxes.

### Calendar and System Deployment Cycles ([see calendar document](Calendario.pdf))
---
1. **Basic System Functionality (Version 1). AUGUST 2018**.
     - Implementation of the multi-country Cadastral System with open source components.
       - Functionality for the inclusion of cadastral, parcel and orthophoto maps.
       - Consultations of plots with the data of dimensions, cadastral values, uses and others.
       - Superposition of cartography with cadastral maps to improve tax inspection.
       - Making available to the municipalities of the Geographic Viewer as a projection tool for the cadastral parcel.
     - Processes available for creation of layers and files '.SLD' for GeoServer.
     - Client viewer for:
       - Consultation of properties by selecting on the Map (property record).
       - Street View viewer associated with the cadastral parcels.
       - Property selection tool with projection on the Map according to definable filters.
       - Repository of predefined cadastral themes: Cadastral value maps; Maps of land uses; Maps by property tax collection ratio; Crop maps
      - **YOU CAN SEE A DEMONSTRATION OF THE TOOL IN THIS [LINK](https://sede.galileoiys.es/publico/territorio/catastro#)**
2. **Extended Functionality. (Version 2). DECEMBER 2018** (*).
    - Automation with data loading tool in standard XML format.
    - Exchange models of mutation files with national cadastral authorities.
    - Extension of tax analysis tools.
    - Security / audit module.
    - Local facilities and / or in the cloud. Hosting services.
    - Generation of cadastral certificates / certificates. Property inquiries
    - GeoProcessing tools (selection by buffers, merge, etc.).
    - Generation of collection receipts, tax rates and exemptions.
    - Integration with municipal collection systems. Exchange files and direct debits banks.
3. **Extended Functionality II (Version 3). JULY 2019** (*).
    - Extension of the model to other repositories of ** _ Multipurpose Cadastre _ **:
      - Integration with Property Registries and Notariats (and / or other Entities).
      - Control of cadastral mutations. Tests with Blockchain.
      - Planning, Infrastructure and municipal equipment.
      - Rural Cadastre.
      - Development of the **_'Virtual Cadastral Office'_** online for Citizens' Consultations, Processing of cadastre changes, Telematic Payments, Cadastral Tax Transparency.

(*) _The extended functionalities can suppose contracting costs._

### User Guide
---
Explain the basic steps of how to use the digital tool in this section. This is a great place to share screen captures or GIFs which could help others understand handling the tool.
 	
### Installation Guide
---
Provide a step by step guide for how to install the digital tool. In this section, it is recommended to explain the file structure and all of the modules included in the system.

Depending on the kind of digital tool you have, the level of complexity for installation may vary. It might be necessary to install additional components upon which the tool is dependent. If this is the case, be sure to add the next section.

#### 1. Dependencies
The necessary components to deploy the platform are the following:
- Development environment **Microsoft Visual Studio Core**.
- **ASP.net Core 2** (to be published on application servers on Unix, Linux, Ios and Windows). Use "_npm install_" to download all the project dependencies.
- **PostgreSQL** 9.4, or higher, with extension **PostGIS**, or **Oracle** 10.2 or higher with **Spatial Data Option** (SDO).
- **JDeveloper** 12.2, or higher.
- **Geoserver** 2.13, or higher, as a map server (wms publication).
- **Leaflet** ver. 1.3 as a map viewer. In the file "_LeafletPaje.js_" you can find the definition of the map layers, which must be edited to adjust it to your desired configuration.
- It is recommended to use the tool **"Atlas Styler"**, downloadable from the internet, to define the styles (.sld files) of the thematic maps.
- **Web server IIS see. 8 or higher.??**

#### 2. Database installation.
In this first version, we offer support for two database servers (PostgreSQL and Oracle). Installation of data repositories can be carried out by loading scripts that can be executed from specific database tools such as ***psql*** or ***SqlPlus***.

Scripted installation is a, less automated, manual process, but allows greater control over the process of create the data repository.

- __*PostgreSQL installation.*__ 
> Neccesary scripts to create the repository are located [here](/Databases/Postgres/) and must be executed using the ***psql*** command tool.
Read the ***Readme.txt*** file for detailed instructions on how to carry out this process.

- __*Oracle installation.*__ 
> Neccesary scripts to create the repository are located [here](/Databases/Oracle/) and must be executed using the ***psql*** command tool.
Read the ***Readme.txt*** file for detailed instructions on how to carry out this process.

#### 3. GeoServer installation and configuration.
For the download of Geoserver, the first thing is to go to the official page of free software http://geoserver.org/ and click on the stable version, identified on a green box.

The next step will be to click on the operating system that our team supports. We click on it to download the Geoserver package. Once downloaded, we give it to execute and proceed to the installation following the wizard, and entering the data that is requested (data directory, username and password, port and others).

In the '_Geoserver_' folder of the repository, we give examples of how to define the 'html' of response to a request for information on the map. We include a file "_content.ftl_", "_footer.ftl_" and "_header.ftl_" for its use.
#### 4. Website installation and configuration.

### Development
---
Neccesary components to develope are the following:
#### 1. JDeveloper 12.2
We have used JDeveloper 12.2, with Database Developer role, to design the repository.
The design workspace is located in **LADM Model\DBModelling**.
#### 2. Visual Studio Core
As indicated, we use Microsoft Visual Studio Core development environment and ASP.net Core 2 for publication.
#### 3. ¿ ?

### Code of Conduct 
---
The Code of Conduct establishes the social norms, rules, and responsibility that individuals and organizations are expected to follow when interacting in any way with the digital tool and its respective community.

For more details, see the file [CODE-OF-CONDUCT.md](/en/CODE-OF-CONDUCT-EN.md). 

### Authorship
---
* **Galileo Ingeniería y Servicios, S.A. https://www.galileoiys.es/**
* Juan Antonio Ubalde <jubalde@galileoiys.es>
* Gregorio Martín <gmartin@galileoiys.es>
* Domingo Rodríguez <drodriguez@galileoiys.es>
* Nicolás Hernández <nhernandez@galileoiys.es>

### References
---
* [Galileo Cadastral Management System](http://www.galileoiys.es/portfolio-item/gestion-catastral/)
* [Electronic Headquarters Tax and Territory Management](https://sede.galileoiys.es/publico/territorio/catastro#)
* [Tuluá Electronic Headquarters](http://tulua.galileoiys.es/)
* [Demonstration video Cadastral Management System](https://www.youtube.com/watch?v=DFPdrn-bul8)
* [Demonstrative video Sistema Catastral Tuluá](https://youtu.be/DFPdrn-bul8)
* [SIELOCAL, Portal of Economic Transparency of public entities](http://www.sielocal.com/)
* [Demonstration video SIELOCAL](https://www.youtube.com/watch?v=bDRYJ1C8Ir4)

### Additional Information
---

We have prepared a [website](https://sede.galileoiys.es/publico/territorio/catastro#) where you can see the platform in operation, as well as obtain more information about the project, future development lines, etc.

You can see the [ExecutiveSummary](/../ResumenEjecutivo.pdf) to obtain extended information about the project.

### License 
---
Source code has been released under a BSD license. Please refer to [LICENSE-EN.md](/en/LICENSE-EN.md) for more information.

### Limitation of liability
---

Galileo IyS will not be responsible, under any circumstance, for damage or compensation, moral or patrimonial; direct or indirect; accessory or special; or by way of consequence, foreseen or unforeseen, that could arise::

1. Under any theory of liability, whether by contract, infringement of intellectual property rights, negligence or under any other theory; and/or
2. Due to the use of the Digital Tool, including, but not limited to, potential defects in the Digital Tool, or the loss or inaccuracy of data of any kind. The foregoing includes expenses or damages associated with communication failures and / or malfunctions of computers, linked to the use of the Digital Tool.

