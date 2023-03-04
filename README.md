
<p align="center">
    <h3 align="center">Juan David Leon Barrera</h3>
	<p align="center">
		<img src="https://img.shields.io/badge/.NET-5C2D91?logo=.net&logoColor=white" alt="template repository">
		<img src="https://img.shields.io/static/v1?label=proyecto&message=Api Rest&color=white" alt="v1.0.0">
		<img src="https://img.shields.io/static/v1?label=version&message=1.0.0&color=red" alt="v1.2">
		<img src="https://img.shields.io/static/v1?label=licencia&message=wilmilcard&color=green" alt="no tiene">
	</p>
    <p align="center">
        <a href="https://nevergate.com.co/"><img src="https://nevergate.com.co/otros/portafolio/images/logo.png" width="200"></a>
    </p>
</p>


# 🚩 Objetivo

Este proyecto esta desarrollado C# .net 5 utilizando CodeFirst y MySql; con el fin de demostrar habilidades en el manejo del framework y mejorar los conocimientos aprendidos por medio de unos videos tutoriales que se subieron a YouTube, evitando usar Sql en las consultas; para ello se planteo un ejercicio de la base de datos de Colombia. con el fin de darle solución desde el BackEnd.

Los enlaces a los tutoriales estan aqui:

🍂 **[Web del desarrollador](https://nevergate.com.co/)** 🍂

- **[Tutorial 1 : CodeFirst, Migrations, Seeder, MySql](https://youtu.be/h9QKQa7NO7Q)**
- **[Tutorial 2 : Creacion de repositorio y Linq](https://youtu.be/bq2fPVvGLTE)**
- **[Tutorial 3 : CRUD y Consultas Avanzadas](https://youtu.be/SmIaZnbHiYQ)**
- **[Tutorial 4 : Authentication con JWT](https://youtu.be/aAu_1RmEffY)**
- **[Tutorial 5 : Fakers con Bogus](https://youtu.be/eI-DjzBrWRo)**

# 📄 Descripción del proyecto

## ✔ Reto

Se tiene una base de datos en SQL (unos Scripts) la dea es poder organizar la BD y las consultas, usando Authentication. La meta es que las personas aprendan a tener un mejor tipo y estilo de programacion, mas limpio y rapido.

## ❌ Supuestos y restricciones

- No tiene por el momento.
- Tener en cuenta que los scripts originales de la BD estaras en el proyecto principal en la carpeta Materials. 

# 🔥 Ejecucion de proyecto

Para que el proyecto funcione correctamente se debe de tener instalado:

- IDE de desarrollo (Visual Studio 2019 - 2022)
- MySql
- XAMMP

Una vez se tengan las herramientas instaladas:

1. Clonar el repositorio
2. Crear en MySql una base de datos llamada "colombia"
    - 💡 Si desea cambiarle el nombre es tan facil como ir al proyecto GameStore.API y en el `appsetting.json`, en `ConectionsStrings` editar la conexion `conn_mysql` cambiar la propiedad **database = Nombre_Base_Datos** en la cadena de conexion.
3. Abrir la consola de "Administrador de paquetes" y en el proyecto donde se ejecutara la consola ponerlo en `GameStore.Domain`. Ejecutar el comando `update-database`; 
esto creara las tablas y las llenara con el *sedder*
4. Luego ejecutar el proyecto con **IIS Express**.
5. Ya estara corriendo la aplicacion desde en endpoint de swagger en la ruta estandar https://localhost:44356/swagger/index.html

# 🧪 API

En este momento el Api solo cuenta con lo necesario para los tutoriales, aun asi se plantea mas adelante crear el propio OpenApi para que cualquiera lo consuma.

Esta API puede ir mejorando y cambiando, pero mientras tanto esta es una muestra de lo que puede hacer 🛴
    
