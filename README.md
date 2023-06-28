# OnionCrafter.DataAccess

[![NuGet](https://img.shields.io/nuget/v/OnionCrafter.DataAccess.svg)](https://www.nuget.org/packages/OnionCrafter.DataAccess/)

![](https://github.com/Dtopiast/OnionCrafter.DataAccess/blob/main/Images/Logo.png)

OnionCrafter.DataAccess es una librer�a que proporciona un conjunto de interfaces para gestionar el acceso a datos y crear una capa de abstracci�n superior basada en Entity Framework Core.

## Descripci�n

El objetivo principal de OnionCrafter.DataAccess es simplificar y estandarizar el acceso a datos en aplicaciones que utilizan Entity Framework Core como su ORM (Object-Relational Mapping). Esta librer�a proporciona un conjunto de interfaces que act�an como contratos para definir operaciones comunes de acceso a datos, como consultas, inserciones, actualizaciones y eliminaciones.

Al utilizar OnionCrafter.DataAccess, puedes aprovechar las ventajas de Entity Framework Core y, al mismo tiempo, crear una capa de abstracci�n que facilite el desarrollo y mantenimiento del c�digo. Esta capa de abstracci�n te permite separar las preocupaciones relacionadas con la l�gica de negocio de las operaciones de acceso a datos, lo que resulta en un c�digo m�s modular, flexible y f�cil de probar.

## Caracter�sticas

- **Interfaces de acceso a datos:** OnionCrafter.DataAccess proporciona un conjunto de interfaces bien definidas para realizar operaciones de acceso a datos, incluyendo consultas, inserciones, actualizaciones y eliminaciones. Estas interfaces act�an como contratos que puedes implementar en tus clases de repositorio o servicios de acceso a datos.

- **Abstracci�n de Entity Framework Core:** Al utilizar las interfaces proporcionadas por OnionCrafter.DataAccess, puedes abstraerte de los detalles espec�ficos de implementaci�n de Entity Framework Core. Esto te permite cambiar f�cilmente el proveedor de base de datos subyacente o aplicar mejoras en el acceso a datos sin afectar la l�gica de negocio de tu aplicaci�n.

- **Mayor modularidad y mantenibilidad:** Al separar la l�gica de negocio de las operaciones de acceso a datos, OnionCrafter.DataAccess fomenta una arquitectura m�s limpia y modular. Esto facilita el mantenimiento del c�digo y permite una mayor flexibilidad a la hora de realizar cambios en la capa de acceso a datos.

## Requisitos

- Entity Framework Core: OnionCrafter.DataAccess se basa en Entity Framework Core, por lo que debes tenerlo instalado en tu proyecto para utilizar esta librer�a.

## Instalaci�n

Puedes instalar OnionCrafter.DataAccess a trav�s de NuGet. Simplemente agrega el paquete a tu proyecto utilizando el administrador de paquetes NuGet o agregando la siguiente l�nea en tu archivo de configuraci�n de paquetes:

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
4. Env�a una solicitud de extracci�n (pull request) describiendo los cambios realizados.

## Licencia

OnionCrafter.DataAccess se distribuye bajo la licencia MPL 2. Puedes encontrar m�s detalles en el archivo [LICENSE](LICENSE.txt) del proyecto.

## Contacto

Si tienes alguna pregunta o sugerencia relacionada con OnionCrafter.DataAccess, no dudes en ponerte en contacto con nosotros a trav�s de [email protected]

Esperamos que OnionCrafter.DataAccess sea de utilidad para tu proyecto. �Gracias por usar nuestra librer�a!