Debe disponer de un cliente Oracle con la herramienta de sql (sqlplus.exe).

1. Modificar el script "1. Create DB.sql" para establecer el parámetro <usr_tablespace> (Nombre del tablespace de usuario de la base de datos)

2. Ejecutar los scripts "1. Create DB.sql" y "2. Carga Datos.sql" según los comandos:

   sqlplus -S sys/<password>@<sid> as sysdba @"1. Create DB.sql"
   sqlplus -S sys/<password>@<sid> as sysdba @"2. Carga Datos.sql"

DONDE:
	<password> es la contraseña del usuario sys
	<sid> es el nombre de servicio.
