# Cassandra Query Optimizer Skill

> **Category:** Tech Skills > Database > Cassandra

## Overview

Optimizes Cassandra queries with CQL best practices, secondary indexes, and materialized views for efficient distributed queries

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [cassandra-query-optimizer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
cassandra-query-optimizer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@cassandra-query-optimizer` agent from the Independent Agents catalogue.

## Key Capabilities

- Optimize CQL queries for partition-based access
- Evaluate and create secondary indexes where appropriate
- Design materialized views for alternative query paths
- Use tracing to diagnose query performance

## Technology Standards Applied

- **CQL Best Practices**: Query patterns that work well with Cassandra
- **SAI Indexes**: Storage Attached Indexes for flexible queries
- **Query Tracing**: Distributed query analysis with tracing