**Languages:** [English](Readme.md) · [Español](README.es.md)

# EstaWebSeAutodestruira

<!-- BEGIN project-context -->

## Historical dates and evidence

**Reference year for this version: 2020.** This uses the most recent source or configuration file with a recoverable historical date; the exact creation date could not be confirmed.

- Most recent datable file: **2020-05-10**, [`pieces/EstaWebSeAutodestruira/appsettings.json`](appsettings.json); date of the commit modifying the file, recovered from local Git history.
- First record in the original Git repository containing this code: **2020-05-10**. This may be an import and does not establish when the code was first written.
- Most recently published dependency among those checked: [Microsoft.EntityFrameworkCore.SqlServer 3.1.0-preview1.19506.2](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/3.1.0-preview1.19506.2), published on **2019-10-15** (declared version), in [`pieces/EstaWebSeAutodestruira/EstaWebSeAutodestruira.csproj`](EstaWebSeAutodestruira.csproj).
- Additional reference: target `netcoreapp3.1` in [`pieces/EstaWebSeAutodestruira/EstaWebSeAutodestruira.csproj`](EstaWebSeAutodestruira.csproj); its [stable release was published on 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). This indicates the technology generation; earlier preview releases may have existed.

A dependency's publication places the preserved configuration at or after that version, if the reference is valid. Package updates may be much newer than the project's beginnings. Packages were not restored to verify this.

October 2026 copy timestamps and documents generated during this review were excluded. Recoverable dates do not guarantee that there are no later, undated changes.

## Why this is worth exploring

The prototype keeps messages in memory, records LastUpdate, and allows adding messages or retrieving a random one. The idea of an ephemeral website is sketched out; the visible service has no complete self-destruct timer.

Code entry points:

- [`MessageService.cs`](MessageService.cs)
- [`Controllers/MessageController.cs`](Controllers/MessageController.cs)

<!-- END project-context -->

