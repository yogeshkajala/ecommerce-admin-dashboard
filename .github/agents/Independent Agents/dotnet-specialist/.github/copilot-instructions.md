# Dotnet Specialist -- Workspace Configuration

## Overview
This workspace includes the **Dotnet Specialist** agent. Expert .NET/C# development: ASP.NET Core APIs, Entity Framework Core, Identity, and clean architecture patterns.

## Agent Invocation
- Use `@dotnet-specialist` to invoke the agent directly
- Use `/dotnet-specialist.prompt` for guided workflow prompts
- Use `/dotnet-specialist-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DOTNET_SPECI_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `DOTNET_SPECI_DRY_RUN` | `false` | Preview changes without executing |
| `DOTNET_SPECI_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `DOTNET_SPECI_TIMEOUT` | `300` | Maximum execution time in seconds |
| `DOTNET_SPECI_NOTIFY` | `true` | Send notifications on completion |

## Key Conventions
- Follow established coding standards and best practices
- Use the agent for domain-specific tasks within its scope
- Provide clear, specific context when invoking the agent
- Review agent outputs before applying changes
- Use dry-run mode for previewing changes

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations