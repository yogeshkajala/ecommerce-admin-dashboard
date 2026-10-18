# PostgreSQL Indexing Specialist Skill

> **Category:** Tech Skills > Database > PostgreSQL

## Overview

Designs optimal indexing strategies for PostgreSQL including partial indexes, covering indexes, and expression indexes for complex workloads

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [postgresql-indexing-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
postgresql-indexing-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@postgresql-indexing-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Design multi-column indexes with proper column order
- Create partial indexes for filtered queries
- Implement covering indexes with INCLUDE columns
- Build expression indexes for computed values

## Technology Standards Applied

- **PostgreSQL Indexes**: Index type selection and design guidelines
- **Covering Indexes**: Index-only scans with INCLUDE columns
- **Partial Indexes**: Conditional indexing for filtered workloads