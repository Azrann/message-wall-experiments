# EstaWebSeAutodestruira

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2020.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2020-05-10**, [`pieces/EstaWebSeAutodestruira/appsettings.json`](appsettings.json); fecha del commit que modificó el archivo, recuperada del Git local.
- Primer registro del repositorio Git original que contiene este código: **2020-05-10**. Puede corresponder a una importación; no prueba cuándo se escribió por primera vez.
- Dependencia fechada más reciente entre las comprobadas: [Microsoft.EntityFrameworkCore.SqlServer 3.1.0-preview1.19506.2](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/3.1.0-preview1.19506.2), publicada el **2019-10-15** (versión declarada), en [`pieces/EstaWebSeAutodestruira/EstaWebSeAutodestruira.csproj`](EstaWebSeAutodestruira.csproj).
- Referencia adicional: destino `netcoreapp3.1` en [`pieces/EstaWebSeAutodestruira/EstaWebSeAutodestruira.csproj`](EstaWebSeAutodestruira.csproj); su [versión estable se publicó el 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

La publicación de una dependencia sitúa la configuración conservada a partir de esa versión, si la referencia es válida. Una actualización de paquetes puede ser mucho más reciente que el inicio del proyecto. No se restauraron paquetes para comprobarlo.

Se descartaron las marcas de tiempo de la copia de octubre de 2026 y los documentos generados durante esta revisión. Las fechas recuperables no garantizan que no existan cambios posteriores sin datar.

## Por qué merece la pena mirarlo

El prototipo mantiene mensajes en memoria, registra LastUpdate y permite añadirlos o recuperar uno aleatorio. La idea de una web efímera está esbozada; el servicio visible no incluye un temporizador de autodestrucción completo.

Puntos de entrada al código:

- [`MessageService.cs`](MessageService.cs)
- [`Controllers/MessageController.cs`](Controllers/MessageController.cs)

<!-- END project-context -->

