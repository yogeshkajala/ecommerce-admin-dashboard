# GraphQL Resolver Specialist Skill

> **Category:** Tech Skills > Others > GraphQL

## Overview

Implements GraphQL resolvers with proper data loading, N+1 prevention with DataLoader, and error handling patterns

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [graphql-resolver-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
graphql-resolver-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@graphql-resolver-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Implement field-level and type-level resolvers
- Prevent N+1 with DataLoader batching
- Handle authentication and authorization in resolvers
- Implement input validation and error handling

## Technology Standards Applied

- **Resolvers**: Resolver implementation patterns
- **DataLoader**: Batching and caching for N+1 prevention
- **Error Handling**: GraphQL error specification and formatting