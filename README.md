# OnionCrafter.DataAccess

[![NuGet](https://img.shields.io/nuget/v/OnionCrafter.DataAccess.svg)](https://www.nuget.org/packages/OnionCrafter.DataAccess/)

![](https://github.com/Dtopiast/OnionCrafter.DataAccess/blob/main/Images/Logo.png)

OnionCrafter.DataAccess es una librería que proporciona un conjunto de interfaces para gestionar el acceso a datos y crear una capa de abstracción superior basada en Entity Framework Core.

## Descripción

El objetivo principal de OnionCrafter.DataAccess es simplificar y estandarizar el acceso a datos en aplicaciones que utilizan Entity Framework Core como su ORM (Object-Relational Mapping). Esta librería proporciona un conjunto de interfaces que actúan como contratos para definir operaciones comunes de acceso a datos, como consultas, inserciones, actualizaciones y eliminaciones.

Al utilizar OnionCrafter.DataAccess, puedes aprovechar las ventajas de Entity Framework Core y, al mismo tiempo, crear una capa de abstracción que facilite el desarrollo y mantenimiento del código. Esta capa de abstracción te permite separar las preocupaciones relacionadas con la lógica de negocio de las operaciones de acceso a datos, lo que resulta en un código más modular, flexible y fácil de probar.

## Características

- **Interfaces de acceso a datos:** OnionCrafter.DataAccess proporciona un conjunto de interfaces bien definidas para realizar operaciones de acceso a datos, incluyendo consultas, inserciones, actualizaciones y eliminaciones. Estas interfaces actúan como contratos que puedes implementar en tus clases de repositorio o servicios de acceso a datos.

- **Abstracción de Entity Framework Core:** Al utilizar las interfaces proporcionadas por OnionCrafter.DataAccess, puedes abstraerte de los detalles específicos de implementación de Entity Framework Core. Esto te permite cambiar fácilmente el proveedor de base de datos subyacente o aplicar mejoras en el acceso a datos sin afectar la lógica de negocio de tu aplicación.

- **Mayor modularidad y mantenibilidad:** Al separar la lógica de negocio de las operaciones de acceso a datos, OnionCrafter.DataAccess fomenta una arquitectura más limpia y modular. Esto facilita el mantenimiento del código y permite una mayor flexibilidad a la hora de realizar cambios en la capa de acceso a datos.

## Requisitos

- Entity Framework Core: OnionCrafter.DataAccess se basa en Entity Framework Core, por lo que debes tenerlo instalado en tu proyecto para utilizar esta librería.

## Instalación

Puedes instalar OnionCrafter.DataAccess a través de NuGet. Simplemente agrega el paquete a tu proyecto utilizando el administrador de paquetes NuGet o agregando la siguiente línea en tu archivo de configuración de paquetes:

```bash
dotnet add package OnionCrafter.DataAccess
```

## Uso

_Writring..._

## Contribuciones

Las contribuciones son bienvenidas. Si deseas contribuir a OnionCrafter.DataAccess, puedes seguir los siguientes pasos:

1. Haz un fork del repositorio.
2. Crea una rama para tus cambios.
3. Realiza los cambios y realiza los commits.
4. Envía una solicitud de extracción (pull request) describiendo los cambios realizados.

## Licencia

OnionCrafter.DataAccess se distribuye bajo la licencia MPL 2. Puedes encontrar más detalles en el archivo [LICENSE](LICENSE.txt) del proyecto.

## Contacto

Si tienes alguna pregunta o sugerencia relacionada con OnionCrafter.DataAccess, no dudes en ponerte en contacto con nosotros a través de [email protected]

Esperamos que OnionCrafter.DataAccess sea de utilidad para tu proyecto. ¡Gracias por usar nuestra librería!