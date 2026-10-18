# .NET DI Specialist Skill

> **Category:** Tech Skills > Backend > .NET

## Overview

Configures dependency injection in ASP.NET Core with proper lifetimes, factory patterns, and service registration for maintainable applications

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [dotnet-dependency-injection-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
dotnet-dependency-injection-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@dotnet-dependency-injection-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure service registration with proper lifetimes
- Implement factory patterns for complex dependencies
- Resolve captive dependency and scope issues
- Build decorator and composite patterns with DI

## Technology Standards Applied

- **DI Guidelines**: ASP.NET Core dependency injection best practices
- **Service Lifetimes**: Transient, scoped, singleton selection criteria
- **Captive Dependencies**: Avoiding scope misalignment issues