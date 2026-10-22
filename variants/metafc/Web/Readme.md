**Languages:** [English](Readme.md) · [Español](README.es.md)

# Web

<!-- BEGIN project-context -->

## Historical dates and evidence

**Reference year for this version: 2020.** This uses the most recent source or configuration file with a recoverable historical date; the exact creation date could not be confirmed.

- Most recent datable file: **2020-04-22**, [`metafc/src/Web/Pages/Index.cshtml.cs`](Pages/Index.cshtml.cs); preserved modification timestamp.
- First record in the original Git repository containing this code: **2014-10-05**. This may be an import and does not establish when the code was first written.
- Additional reference: target `netcoreapp3.1` in [`metafc/src/Web/Web.csproj`](Web.csproj); its [stable release was published on 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). This indicates the technology generation; earlier preview releases may have existed.

## Why this is worth exploring

This small API separates messages from the controller, with operations to add and retrieve a random message. Its size makes it possible to follow the prototype end to end and compare it with the other message wall variants.

Code entry points:

- [`MessageService.cs`](MessageService.cs)
- [`Controllers/MessageController.cs`](Controllers/MessageController.cs)

<!-- END project-context -->

