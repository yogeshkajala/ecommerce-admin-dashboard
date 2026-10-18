# PostgreSQL Query Optimizer Skill

> **Category:** Tech Skills > Database > PostgreSQL

## Overview

Analyzes and optimizes PostgreSQL queries using EXPLAIN plans, index strategies, and query rewriting for maximum performance

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [postgresql-query-optimizer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
postgresql-query-optimizer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@postgresql-query-optimizer` agent from the Independent Agents catalogue.

## Key Capabilities

- Analyze EXPLAIN ANALYZE output for bottlenecks
- Design B-tree, GIN, GiST, and BRIN index strategies
- Rewrite queries with CTEs, window functions, and lateral joins
- Optimize join order and statistics accuracy

## Technology Standards Applied

- **PostgreSQL Performance**: Official query optimization documentation
- **Index Types**: Choosing appropriate index types for workloads
- **EXPLAIN**: Execution plan analysis methodology