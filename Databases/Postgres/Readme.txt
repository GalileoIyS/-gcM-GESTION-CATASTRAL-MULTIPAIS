1. Ejecutar el script "0. Create USER y DB.sql" mediante el comando:

  psql -h <<host>> -p <<port>> -U postgres -d postgres -W -f "0. Create USER y DB.sql"

2. Ejecutar los scripts según el orden (desde 1. hasta 3.) mediante los comandos:

  psql -h <<host>> -p <<port>> -U postgres -d "GCM" -W -f "1. Create DB.sql" 
  psql -h <<host>> -p <<port>> -U postgres -d "GCM" -W -f "2. Geometry Columns.sql" 
  psql -h <<host>> -p <<port>> -U postgres -d "GCM" -W -f "3. Carga Datos.sql" 

DONDE:
	<<host>> es el servidor POSTGRES.
	<<port>> es el puerto de acceso.

NOTA: El script "2. Geometry Columns.sql" debe ser modificado previamente para establecer el SRID de los campos de geometría.
