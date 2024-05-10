# EdgarHernandez.NativApps

Configuración y Ejecución de la Aplicación API Web Localmente
Requisitos Previos:
-Visual Studio instalado en tu sistema.
-SQL Server Express o cualquier otro motor de base de datos compatible con Sql Server.

Pasos para Configurar y Ejecutar la Aplicación:
-Clonar el Repositorio
    Clona este repositorio en tu máquina local utilizando el siguiente comando:
    "git clone https://github.com/ehernadez/EdgarHernandez.NativApps.git"
-Abrir el Proyecto en Visual Studio
    Abre Visual Studio y selecciona la opción "Abrir un Proyecto o Solución". Navega hasta el directorio donde clonaste el repositorio y selecciona el archivo de solución (.sln) del proyecto.
-Configurar la Base de Datos
    Abre SQL Server Management Studio o cualquier herramienta que prefieras para administrar bases de datos SQL Server.
    Ejecuta el script de creación de base de datos para crear la base de datos y las tablas necesarias. Este script se encuentra en la carpeta SQL dentro del proyecto.
-Configurar la Cadena de Conexión
    Abre el archivo appsettings.json en el proyecto de APIRest (NativApps.ApiRest).
    En la sección "ConnectionStrings"-"NativAppsConnectionString", ajusta la cadena de conexión para que apunte a tu base de datos local.
-Compilar y Ejecutar la Aplicación
    Compila la solución en Visual Studio.
    Una vez compilada con éxito, ejecuta la aplicación presionando F5 o seleccionando la opción de ejecución en Visual Studio.
-Probar la API
    Abre tu navegador web o utiliza Postman para probar la API.
    Accede a las rutas y endpoints de la API. Puedes importar el archivo de la coleccion de postman que se encuentra en la raiz del proyecto  NativApps.Product.postman_collection.json
    Importa el archivo NativApps.Product.postman_collection.json abriendo postman y haciendo clic en la opcion "Importar", luego arrastra o selecciona el archivo de la colecion.
    -Asegurate de configurar las variables de la Coleccion:
        En postman haz clic sobre la coleccion "NativApps.Product" en el panel izquierdo de la aplicacion.
        Luego de seleccionarla se abrira la ventana de Overview.
        Selecciona el Tab "Variables"
        Configura la variable "api_url" agrega el valor de la url del entorno donde se va a probar la api ej: "http://localhost:5260/api" (independientemente de cual sea el entorno la url debe terminar con la palabra "api" como se muestra en el ejemplo).
        Configura la variable "token" para consumir los endpoint se necesita de un usuario logueado, busca el endpoint Login que esta en la carpeta de Auth dentro de postman, coloca las credenciales de userName y Password y consume el endpoint.
        Este endpoint retornara un Token, copia el texto del token y agregalo en la variable de postman mencionada anteriormente.
    -Consumo Login:
        Al ejecutar el script de la base de datos se creara el siguiente usuario que servira para el consumo de los endpoint:
        userName: "nativapps"
        passWors: "test1"

