# RestAdmin

RestAdmin es un sistema de facturación completo para restaurantes. Es una API web creada en C# y .NET, utilizando Swagger para la documentación. El sistema incluye funcionalidades de CRUD (Crear, Leer, Actualizar, Eliminar) y consultas especializadas a la base de datos.

![Licencia](https://img.shields.io/badge/license-MIT-blue.svg) ![Versión](https://img.shields.io/badge/version-1.0.0-blue.svg)

## Índice

1. [Descripción](#descripción)
2. [Características](#características)
3. [Tecnologías](#tecnologías)
4. [Instalación](#instalación)
5. [Uso](#uso)
6. [Contribución](#contribución)
7. [Licencia](#licencia)
8. [Créditos](#créditos)
9. [Contacto](#contacto)

## Descripción

RestAdmin es una solución de facturación para restaurantes que permite gestionar órdenes, facturas y datos de clientes a través de una API robusta. El sistema permite realizar operaciones CRUD y ejecutar consultas avanzadas sobre la base de datos para obtener información específica y útil.

## Características

- **CRUD Completo:** Crear, leer, actualizar y eliminar registros de órdenes, facturas y clientes.
- **Consultas Especializadas:** Ejecuta consultas avanzadas para obtener información detallada.
- **Documentación Swagger:** Interactúa con la API de manera intuitiva a través de Swagger UI.
- **Seguridad y Control:** Gestión de acceso y autorización para proteger datos sensibles.

## Tecnologías

- **Lenguajes:** C#
- **Frameworks:** .NET Core
- **Documentación:** Swagger
- **Base de Datos:** MySQL
- **ORM:** Entity Framework Core

## Instalación

### Requisitos Previos

- **.NET Core SDK:** Asegúrate de tener instalado el SDK de .NET Core (versión 3.1 o superior).
- **MySQL:** Debes tener MySQL instalado y configurado en tu máquina.

### Clonación del Repositorio

```bash
git clone https://github.com/tu_usuario/restadmin.git
```

### Instalación de Dependencias

```bash
cd restadmin
dotnet restore
```

### Configuración

1. **Base de Datos:**
   - Crea una base de datos en MySQL y configura la cadena de conexión en `appsettings.json`.

2. **Migraciones:**
   - Ejecuta las migraciones para crear las tablas en la base de datos:

   ```bash
   dotnet ef database update
   ```

### Ejecución

Para ejecutar la API en el entorno local:

```bash
dotnet run
```

La API estará disponible en `http://localhost:5000`. Puedes acceder a la documentación Swagger en `http://localhost:5000/swagger`.

## Uso

Para interactuar con la API, puedes utilizar herramientas como Postman o la interfaz Swagger UI integrada. Aquí tienes un ejemplo de cómo hacer una solicitud GET para obtener todas las órdenes:

```bash
curl -X GET "http://localhost:5000/api/orders"
```

## Contribución

Si deseas contribuir al proyecto, sigue estos pasos:

1. **Haz un fork del repositorio.**

2. **Crea una rama para tu característica:**

   ```bash
   git checkout -b feature/nueva-caracteristica
   ```

3. **Realiza tus cambios y haz commits:**

   ```bash
   git commit -am 'Añadida nueva característica'
   ```

4. **Envía la rama:**

   ```bash
   git push origin feature/nueva-caracteristica
   ```

5. **Crea un pull request en GitHub.**

### Código de Conducta

Por favor, sigue el código de conducta establecido para mantener un ambiente colaborativo.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT - consulta el archivo [LICENSE](LICENSE) para más detalles.

## Créditos

- **Autores:**
  - Kevin Alvarez Diaz
  - Luis Alejandro Londoño Valle
  - Alejandro Castrillon

- **Bibliotecas o Recursos:** Agradecimientos a cualquier biblioteca o recurso utilizado en el proyecto.

## Contacto

- **Kevin Alvarez Diaz:** [GitHub](https://github.com/KevinAlvarezD)
- **Luis Alejandro Londoño Valle:** [GitHub](https://github.com/AlejandroLondonoValle)
- **Alejandro Castrillon:** [GitHub](https://github.com/CODEALEJO)
```
