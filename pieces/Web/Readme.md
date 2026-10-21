# Web

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2020.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2020-05-10**, [`pieces/Web/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js`](wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js); fecha del commit que modificó el archivo, recuperada del Git local.
- Primer registro del repositorio Git original que contiene este código: **2020-05-10**. Puede corresponder a una importación; no prueba cuándo se escribió por primera vez.
- Referencia adicional: destino `netcoreapp3.1` en [`pieces/Web/Web.csproj`](Web.csproj); su [versión estable se publicó el 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

Se descartaron las marcas de tiempo de la copia de octubre de 2026 y los documentos generados durante esta revisión. Las fechas recuperables no garantizan que no existan cambios posteriores sin datar.

## Por qué merece la pena mirarlo

La pequeña API separa mensajes y controlador, con operaciones de añadir y recuperar un mensaje aleatorio. Su tamaño permite seguir un prototipo de principio a fin y compararlo con las otras variantes de muros de mensajes.

Puntos de entrada al código:

- [`MessageService.cs`](MessageService.cs)
- [`Controllers/MessageController.cs`](Controllers/MessageController.cs)

<!-- END project-context -->

