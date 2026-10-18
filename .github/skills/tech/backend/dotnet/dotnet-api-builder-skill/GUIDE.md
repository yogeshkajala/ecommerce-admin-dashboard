# .NET API Builder Skill

> **Category:** Tech Skills > Backend > .NET

## Overview

Builds RESTful and minimal APIs with ASP.NET Core including endpoint routing, model validation, and OpenAPI documentation

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [dotnet-api-builder-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
dotnet-api-builder-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@dotnet-api-builder` agent from the Independent Agents catalogue.

## Key Capabilities

- Build minimal APIs with endpoint routing
- Implement controller-based APIs with proper routing
- Configure model validation with FluentValidation
- Generate OpenAPI documentation with Swashbuckle

## Technology Standards Applied

- **ASP.NET Core API**: Minimal API and controller patterns
- **OpenAPI Specification**: API documentation with Swagger/OpenAPI
- **REST Conventions**: RESTful API design best practices