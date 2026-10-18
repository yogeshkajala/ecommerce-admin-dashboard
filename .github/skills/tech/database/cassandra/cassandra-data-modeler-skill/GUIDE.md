# Cassandra Data Modeler Skill

> **Category:** Tech Skills > Database > Cassandra

## Overview

Designs Cassandra data models with proper partition keys, clustering columns, and denormalization for distributed query patterns

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [cassandra-data-modeler-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
cassandra-data-modeler-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@cassandra-data-modeler` agent from the Independent Agents catalogue.

## Key Capabilities

- Design partition keys for balanced data distribution
- Choose clustering columns for sort order
- Implement denormalization for query-driven design
- Create materialized views for alternative query patterns

## Technology Standards Applied

- **Cassandra Data Modeling**: Query-driven data modeling best practices
- **Partition Key Design**: Even distribution and size management
- **Denormalization**: Trading storage for query performance