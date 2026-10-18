# PostgreSQL Extension Developer Skill

> **Category:** Tech Skills > Database > PostgreSQL

## Overview

Creates and manages PostgreSQL extensions including PostGIS, pgvector, and custom extensions for specialized database functionality

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [postgresql-extension-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
postgresql-extension-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@postgresql-extension-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Install and configure PostGIS for geospatial data
- Set up pgvector for AI embedding similarity search
- Configure pg_stat_statements for query monitoring
- Build custom extensions with C or PL/pgSQL

## Technology Standards Applied

- **PostgreSQL Extensions**: Extension installation and management
- **PostGIS**: Geospatial data types and functions
- **pgvector**: Vector similarity search extension