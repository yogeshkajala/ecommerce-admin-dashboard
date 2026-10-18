# MySQL Query Optimizer Skill

> **Category:** Tech Skills > Database > MySQL

## Overview

Analyzes and optimizes MySQL queries using EXPLAIN, index optimization, and query rewriting for InnoDB storage engine performance

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [mysql-query-optimizer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
mysql-query-optimizer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@mysql-query-optimizer` agent from the Independent Agents catalogue.

## Key Capabilities

- Analyze queries with EXPLAIN FORMAT=JSON
- Design composite indexes for covering queries
- Optimize InnoDB buffer pool configuration
- Rewrite queries to avoid full table scans

## Technology Standards Applied

- **MySQL EXPLAIN**: Query execution plan analysis
- **InnoDB Optimization**: Storage engine tuning guidelines
- **Performance Schema**: Query monitoring and diagnostics