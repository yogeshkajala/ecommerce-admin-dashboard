# MongoDB Schema Designer Skill

> **Category:** Tech Skills > Database > MongoDB

## Overview

Designs MongoDB document schemas with proper embedding, referencing, and polymorphism patterns for scalable NoSQL data modeling

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [mongodb-schema-designer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
mongodb-schema-designer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@mongodb-schema-designer` agent from the Independent Agents catalogue.

## Key Capabilities

- Design embedded documents for one-to-few relationships
- Implement reference patterns for one-to-many relationships
- Create polymorphic schemas with discriminator fields
- Design bucket patterns for time-series data

## Technology Standards Applied

- **MongoDB Data Modeling**: Official schema design patterns and anti-patterns
- **Schema Patterns**: Bucket, outlier, and computed patterns
- **JSON Schema**: Document validation with JSON Schema