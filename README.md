**Languages:** [English](README.md) · [Español](README.es.md)

# message-wall-experiments

Web message wall prototypes and related applications.

<!-- BEGIN project-context -->

## Historical dates and evidence

**Reference year for this version: 2021.** This uses the most recent source or configuration file with a recoverable historical date; the exact creation date could not be confirmed.

- Most recent datable file: **2021-04-07**, [`pieces/EstaWebSeAutodestruira.sln`](pieces/EstaWebSeAutodestruira.sln); date of the commit modifying the file, recovered from local Git history.
- Earliest record among the original Git repositories included: **2014-10-05**. This may be an import and does not establish when the code was first written.
- Most recently published dependency among those checked: [Microsoft.EntityFrameworkCore.SqlServer 3.1.0-preview1.19506.2](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/3.1.0-preview1.19506.2), published on **2019-10-15** (declared version), in [`metafc/src/EstaWebSeAutodestruira/EstaWebSeAutodestruira.csproj`](variants/metafc/EstaWebSeAutodestruira/EstaWebSeAutodestruira.csproj).
- Additional reference: target `netcoreapp3.1` in [`metafc/src/EstaWeb/EstaWeb.csproj`](variants/metafc/EstaWeb/EstaWeb.csproj); its [stable release was published on 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). This indicates the technology generation; earlier preview releases may have existed.

A dependency's publication places the preserved configuration at or after that version, if the reference is valid. Package updates may be much newer than the project's beginnings. Packages were not restored to verify this.

October 2026 copy timestamps and documents generated during this review were excluded. Recoverable dates do not guarantee that there are no later, undated changes.

Reference years by component (most recent datable file):

| Component | Year |
| --- | --- |
| [`pieces/EstaWeb`](pieces/EstaWeb/) | 2020 |
| [`pieces/EstaWebSeAutodestruira`](pieces/EstaWebSeAutodestruira/) | 2020 |
| [`pieces/Web`](pieces/Web/) | 2020 |
| [`pieces/EstaWebSeAutodestruira.sln`](pieces/EstaWebSeAutodestruira.sln) | 2021 |
| [`metafc/src/EstaWeb`](variants/metafc/EstaWeb/) | 2020 |
| [`metafc/src/EstaWebSeAutodestruira`](variants/metafc/EstaWebSeAutodestruira/) | 2020 |
| [`metafc/src/Web`](variants/metafc/Web/) | 2020 |
| [`metafc/src/EstaWebSeAutodestruira.sln`](variants/metafc/EstaWebSeAutodestruira.sln) | 2020 |

## Why this is worth exploring

The variants let you compare in-memory message services, random selection, and reading, like, and deletion actions. One variant's name proposes an ephemeral website; the preserved copy is a prototype of that idea.

Code entry points:

- [`pieces/EstaWeb/MessageService.cs`](pieces/EstaWeb/MessageService.cs)
- [`pieces/EstaWebSeAutodestruira/MessageService.cs`](pieces/EstaWebSeAutodestruira/MessageService.cs)
- [`pieces/Web/Controllers/MessageController.cs`](pieces/Web/Controllers/MessageController.cs)

<!-- END project-context -->

## Contents

| Directory | Function |
| --- | --- |
| [`pieces/EstaWeb/`](pieces/EstaWeb/) | Source code |
| [`pieces/EstaWebSeAutodestruira/`](pieces/EstaWebSeAutodestruira/) | Source code |
| [`pieces/Web/`](pieces/Web/) | Source code |
| [`variants/metafc/EstaWeb/`](variants/metafc/EstaWeb/) | Source code |
| [`variants/metafc/EstaWebSeAutodestruira/`](variants/metafc/EstaWebSeAutodestruira/) | Source code |
| [`variants/metafc/Web/`](variants/metafc/Web/) | Source code |

Variants originating in pieces and metafc are retained with their differences.

## Requirements and setup

.NET Core 3.1, ASP.NET Core MVC/SignalR, and SQL Server.

This is a historical copy. Consult each component's project files and README for versions and dependencies. Restore NuGet/npm from the appropriate folder; internal libraries may need rebuilding. Prepare databases and external services using your own accounts.

Preserved solutions:

- `pieces/EstaWebSeAutodestruira.sln`
- `variants/metafc/EstaWebSeAutodestruira.sln`

## Configuration and security

Original secrets have been removed or replaced with `REPLACE_WITH_YOUR_VALUE`. Search for this marker before running and provide values through local configuration or environment variables. Sessions, private keys, signing certificates, databases, logs, deployment profiles, and binary packages are not published. The `.gitignore` protects these local files.

A fresh history is published: old commits remain only in the original local copy. Example values cannot connect to the original services.

## Validation status

A static review and secret scan were performed before publication. Applications, trading operations, deployments, and tests contacting external services were not run. Building with current tools is not guaranteed. Some projects need historical dependencies and assets that are not included.

## Licenses and provenance

Third-party licenses and attributions present in the code are retained. No blanket license is added to components that lacked one. This import preserves local sources and does not claim to be a current version of the original project.
