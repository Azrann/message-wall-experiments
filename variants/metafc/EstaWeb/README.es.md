**Languages:** [English](Readme.md) · [Español](README.es.md)

# EstaWeb

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2020.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2020-04-29**, [`metafc/src/EstaWeb/Views/Shared/_Layout.cshtml`](Views/Shared/_Layout.cshtml); fecha de modificación conservada.
- Primer registro del repositorio Git original que contiene este código: **2014-10-05**. Puede corresponder a una importación; no prueba cuándo se escribió por primera vez.
- Dependencia fechada más reciente entre las comprobadas: [Newtonsoft.Json 8.0.3](https://www.nuget.org/packages/Newtonsoft.Json/8.0.3), publicada el **2016-03-14** (versión declarada), en [`metafc/src/EstaWeb/EstaWeb.csproj`](EstaWeb.csproj).
- Referencia adicional: destino `netcoreapp3.1` en [`metafc/src/EstaWeb/EstaWeb.csproj`](EstaWeb.csproj); su [versión estable se publicó el 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

La publicación de una dependencia sitúa la configuración conservada a partir de esa versión, si la referencia es válida. Una actualización de paquetes puede ser mucho más reciente que el inicio del proyecto. No se restauraron paquetes para comprobarlo.

## Por qué merece la pena mirarlo

El servicio utiliza un ConcurrentDictionary para mensajes y ofrece lectura, likes y borrado. Es interesante observar la semántica de seleccionar un mensaje aleatorio y retirarlo, junto con las limitaciones de mantener el estado en memoria.

Puntos de entrada al código:

- [`MessageService.cs`](MessageService.cs)
- [`Controllers/HomeController.cs`](Controllers/HomeController.cs)

<!-- END project-context -->

