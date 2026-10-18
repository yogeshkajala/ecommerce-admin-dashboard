# .NET Middleware Developer Skill

> **Category:** Tech Skills > Backend > .NET

## Overview

Creates ASP.NET Core middleware for request processing including authentication, logging, error handling, and custom request pipeline stages

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [dotnet-middleware-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
dotnet-middleware-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@dotnet-middleware-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Build custom middleware with proper request/response handling
- Implement middleware with dependency injection
- Configure middleware ordering in the pipeline
- Create conditional middleware with MapWhen and UseWhen

## Technology Standards Applied

- **ASP.NET Middleware**: Official middleware pattern and conventions
- **Request Pipeline**: Middleware ordering and short-circuiting
- **Exception Handling**: Global exception handling middleware patterns