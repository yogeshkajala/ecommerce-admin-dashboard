# TypeScript Decorator Specialist Skill

> **Category:** Tech Skills > Frontend > TypeScript

## Overview

Implements TypeScript decorators for metadata annotation, dependency injection, validation, and cross-cutting concern management

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [typescript-decorator-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
typescript-decorator-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@typescript-decorator-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Build class, method, property, and parameter decorators
- Implement decorator factories with configuration options
- Use reflect-metadata for runtime type information
- Create validation decorators with class-validator patterns

## Technology Standards Applied

- **Decorators Proposal**: TC39 Stage 3 decorator specification
- **Legacy Decorators**: experimentalDecorators flag and patterns
- **Reflect Metadata**: Runtime type reflection with metadata API