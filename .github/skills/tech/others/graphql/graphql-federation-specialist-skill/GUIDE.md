# GraphQL Federation Specialist Skill

> **Category:** Tech Skills > Others > GraphQL

## Overview

Implements GraphQL Federation for composing a supergraph from multiple subgraph services with Apollo Federation

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [graphql-federation-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
graphql-federation-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@graphql-federation-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Design federated schema with entities and keys
- Implement subgraph services with @key directives
- Configure Apollo Router or Gateway
- Implement entity reference resolvers

## Technology Standards Applied

- **Apollo Federation**: Federation specification and patterns
- **Subgraph Design**: Entity ownership and key design
- **Schema Composition**: Supergraph composition rules