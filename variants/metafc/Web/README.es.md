**Languages:** [English](Readme.md) · [Español](README.es.md)

# Web

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2020.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2020-04-22**, [`metafc/src/Web/Pages/Index.cshtml.cs`](Pages/Index.cshtml.cs); fecha de modificación conservada.
- Primer registro del repositorio Git original que contiene este código: **2014-10-05**. Puede corresponder a una importación; no prueba cuándo se escribió por primera vez.
- Referencia adicional: destino `netcoreapp3.1` en [`metafc/src/Web/Web.csproj`](Web.csproj); su [versión estable se publicó el 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

## Por qué merece la pena mirarlo

La pequeña API separa mensajes y controlador, con operaciones de añadir y recuperar un mensaje aleatorio. Su tamaño permite seguir un prototipo de principio a fin y compararlo con las otras variantes de muros de mensajes.

Puntos de entrada al código:

- [`MessageService.cs`](MessageService.cs)
- [`Controllers/MessageController.cs`](Controllers/MessageController.cs)

<!-- END project-context -->

