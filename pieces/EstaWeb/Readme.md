**Languages:** [English](Readme.md) · [Español](README.es.md)

# EstaWeb

<!-- BEGIN project-context -->

## Historical dates and evidence

**Reference year for this version: 2020.** This uses the most recent source or configuration file with a recoverable historical date; the exact creation date could not be confirmed.

- Most recent datable file: **2020-05-10**, [`pieces/EstaWeb/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js`](wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js); date of the commit modifying the file, recovered from local Git history.
- First record in the original Git repository containing this code: **2020-05-10**. This may be an import and does not establish when the code was first written.
- Most recently published dependency among those checked: [Newtonsoft.Json 8.0.3](https://www.nuget.org/packages/Newtonsoft.Json/8.0.3), published on **2016-03-14** (declared version), in [`pieces/EstaWeb/EstaWeb.csproj`](EstaWeb.csproj).
- Additional reference: target `netcoreapp3.1` in [`pieces/EstaWeb/EstaWeb.csproj`](EstaWeb.csproj); its [stable release was published on 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). This indicates the technology generation; earlier preview releases may have existed.

A dependency's publication places the preserved configuration at or after that version, if the reference is valid. Package updates may be much newer than the project's beginnings. Packages were not restored to verify this.

October 2026 copy timestamps and documents generated during this review were excluded. Recoverable dates do not guarantee that there are no later, undated changes.

## Why this is worth exploring

The service uses a ConcurrentDictionary for messages and supports reading, likes, and deletion. Explore the semantics of selecting and removing a random message, alongside the limitations of keeping state in memory.

Code entry points:

- [`MessageService.cs`](MessageService.cs)
- [`Controllers/HomeController.cs`](Controllers/HomeController.cs)

<!-- END project-context -->

