# PostgreSQL Partitioning Specialist Skill

> **Category:** Tech Skills > Database > PostgreSQL

## Overview

Designs and implements PostgreSQL table partitioning with range, list, and hash strategies for scalable data management

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [postgresql-partitioning-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
postgresql-partitioning-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@postgresql-partitioning-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Implement declarative partitioning with range, list, hash
- Design partition pruning for query optimization
- Automate partition creation and maintenance
- Migrate existing tables to partitioned structures

## Technology Standards Applied

- **Table Partitioning**: Declarative partitioning in PostgreSQL 10+
- **Partition Pruning**: Query optimization with partition elimination
- **pg_partman**: Automated partition management extension