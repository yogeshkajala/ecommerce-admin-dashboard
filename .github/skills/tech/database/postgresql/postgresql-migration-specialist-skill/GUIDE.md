# PostgreSQL Migration Specialist Skill

> **Category:** Tech Skills > Database > PostgreSQL

## Overview

Plans and executes database migrations to and from PostgreSQL with schema conversion, data migration, and compatibility testing

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [postgresql-migration-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
postgresql-migration-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@postgresql-migration-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Convert schemas from Oracle, MySQL, SQL Server to PostgreSQL
- Migrate data with minimal downtime using logical replication
- Handle data type mappings and compatibility
- Use pgLoader for efficient bulk data migration

## Technology Standards Applied

- **pgLoader**: Bulk data migration tool for PostgreSQL
- **Flyway**: Schema versioning and migration management
- **AWS SCT**: Schema conversion tool for cloud migrations