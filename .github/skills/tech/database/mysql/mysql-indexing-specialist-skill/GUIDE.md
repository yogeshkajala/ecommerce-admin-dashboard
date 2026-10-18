# MySQL Indexing Specialist Skill

> **Category:** Tech Skills > Database > MySQL

## Overview

Designs optimal MySQL indexing strategies including composite indexes, full-text indexes, and spatial indexes for diverse query workloads

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [mysql-indexing-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
mysql-indexing-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@mysql-indexing-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Design composite indexes with proper column ordering
- Create full-text indexes for text search
- Implement spatial indexes for geospatial queries
- Analyze index usage with sys schema views

## Technology Standards Applied

- **InnoDB Indexes**: Clustered and secondary index design
- **Index Design**: Composite index column ordering guidelines
- **sys Schema**: Index usage monitoring views