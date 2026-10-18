# GitHub Copilot Custom Instructions for .NET Core Development

These instructions configure GitHub Copilot to adopt best practices for .NET Core and ASP.NET Core project management, testing, and debugging.

## Coding Style & Architecture
- Target modern .NET versions (e.g. .NET 8 or 9) by default.
- Prefer Minimal APIs for lightweight web endpoints over controller-based setups, unless controller architecture is explicitly requested.
- Leverage C# primary constructors and pattern matching where applicable.
- Write asynchronous code with `async`/`await` and include `CancellationToken` in API endpoints.

## Project Management
- Always suggest .NET CLI commands (e.g. `dotnet build`, `dotnet run`, `dotnet test`) rather than IDE-specific steps.
- Maintain a structured folder layout (`src/` for applications, `tests/` for test suites).

## Package Management
- When asked to add dependencies, specify the exact `dotnet add package <PackageName>` CLI command instead of editing `.csproj` files directly.

## Testing & Scaffolding
- Generate unit tests using xUnit and FluentAssertions/Shouldly where appropriate.
- Suggest mock setups with `Moq` or `NSubstitute` for interfaces.
