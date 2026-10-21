# message-wall-experiments

Prototipos de muros web de mensajes y aplicaciones relacionadas.

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2021.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2021-04-07**, [`pieces/EstaWebSeAutodestruira.sln`](pieces/EstaWebSeAutodestruira.sln); fecha del commit que modificó el archivo, recuperada del Git local.
- Primer registro entre los repositorios Git originales incluidos: **2014-10-05**. Puede corresponder a una importación; no prueba cuándo se escribió por primera vez.
- Dependencia fechada más reciente entre las comprobadas: [Microsoft.EntityFrameworkCore.SqlServer 3.1.0-preview1.19506.2](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/3.1.0-preview1.19506.2), publicada el **2019-10-15** (versión declarada), en [`metafc/src/EstaWebSeAutodestruira/EstaWebSeAutodestruira.csproj`](variants/metafc/EstaWebSeAutodestruira/EstaWebSeAutodestruira.csproj).
- Referencia adicional: destino `netcoreapp3.1` en [`metafc/src/EstaWeb/EstaWeb.csproj`](variants/metafc/EstaWeb/EstaWeb.csproj); su [versión estable se publicó el 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

La publicación de una dependencia sitúa la configuración conservada a partir de esa versión, si la referencia es válida. Una actualización de paquetes puede ser mucho más reciente que el inicio del proyecto. No se restauraron paquetes para comprobarlo.

Se descartaron las marcas de tiempo de la copia de octubre de 2026 y los documentos generados durante esta revisión. Las fechas recuperables no garantizan que no existan cambios posteriores sin datar.

Años de referencia por componente (archivo más reciente datable):

| Componente | Año |
| --- | --- |
| [`pieces/EstaWeb`](pieces/EstaWeb/) | 2020 |
| [`pieces/EstaWebSeAutodestruira`](pieces/EstaWebSeAutodestruira/) | 2020 |
| [`pieces/Web`](pieces/Web/) | 2020 |
| [`pieces/EstaWebSeAutodestruira.sln`](pieces/EstaWebSeAutodestruira.sln) | 2021 |
| [`metafc/src/EstaWeb`](variants/metafc/EstaWeb/) | 2020 |
| [`metafc/src/EstaWebSeAutodestruira`](variants/metafc/EstaWebSeAutodestruira/) | 2020 |
| [`metafc/src/Web`](variants/metafc/Web/) | 2020 |
| [`metafc/src/EstaWebSeAutodestruira.sln`](variants/metafc/EstaWebSeAutodestruira.sln) | 2020 |

## Por qué merece la pena mirarlo

Las variantes permiten comparar servicios de mensajes en memoria, selección aleatoria y acciones de lectura, likes y borrado. El nombre de una de ellas plantea una web efímera; la copia conservada es un prototipo de esa idea.

Puntos de entrada al código:

- [`pieces/EstaWeb/MessageService.cs`](pieces/EstaWeb/MessageService.cs)
- [`pieces/EstaWebSeAutodestruira/MessageService.cs`](pieces/EstaWebSeAutodestruira/MessageService.cs)
- [`pieces/Web/Controllers/MessageController.cs`](pieces/Web/Controllers/MessageController.cs)

<!-- END project-context -->

## Contenido

| Directorio | Función |
| --- | --- |
| [`pieces/EstaWeb/`](pieces/EstaWeb/) | Código fuente |
| [`pieces/EstaWebSeAutodestruira/`](pieces/EstaWebSeAutodestruira/) | Código fuente |
| [`pieces/Web/`](pieces/Web/) | Código fuente |
| [`variants/metafc/EstaWeb/`](variants/metafc/EstaWeb/) | Código fuente |
| [`variants/metafc/EstaWebSeAutodestruira/`](variants/metafc/EstaWebSeAutodestruira/) | Código fuente |
| [`variants/metafc/Web/`](variants/metafc/Web/) | Código fuente |

Se mantienen las variantes procedentes de pieces y metafc con sus diferencias.

## Requisitos y preparación

.NET Core 3.1, ASP.NET Core MVC/SignalR y SQL Server.

Esta es una copia histórica. Consultar los archivos de proyecto y los README de cada componente para sus versiones y dependencias. Restaurar NuGet/npm desde la carpeta correspondiente; las bibliotecas internas pueden necesitar reconstrucción. Preparar las bases de datos y los servicios externos con cuentas propias.

Soluciones conservadas:

- `pieces/EstaWebSeAutodestruira.sln`
- `variants/metafc/EstaWebSeAutodestruira.sln`

## Configuración y seguridad

Los secretos originales se han eliminado o sustituido por `REPLACE_WITH_YOUR_VALUE`. Buscar este marcador antes de ejecutar y aportar los valores mediante configuración local o variables de entorno. Las sesiones, claves privadas, certificados de firma, bases de datos, registros, perfiles de despliegue y paquetes binarios no se publican. El `.gitignore` protege estos archivos locales.

Se publica un historial nuevo: los commits antiguos permanecen únicamente en la copia local original. Los valores de ejemplo no permiten conectarse a los servicios originales.

## Estado de validación

Se realizó una revisión estática y un escaneo de secretos antes de publicar. No se ejecutaron aplicaciones, operaciones de trading, despliegues ni pruebas que contacten servicios externos. No se garantiza la compilación con herramientas actuales. Algunos proyectos necesitan dependencias históricas y activos que no están incluidos.

## Licencias y procedencia

Se conservan las licencias y atribuciones de terceros presentes en el código. No se añade una licencia global a los componentes que no la tenían. Esta importación conserva fuentes locales y no afirma ser una versión actual del proyecto original.
