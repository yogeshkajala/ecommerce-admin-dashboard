# SQL Server Query Optimizer Skill

> **Category:** Tech Skills > Database > SQL Server

## Overview

Analyzes and optimizes SQL Server queries using execution plans, index tuning, and query store for maximum performance

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [sqlserver-query-optimizer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
sqlserver-query-optimizer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@sqlserver-query-optimizer` agent from the Independent Agents catalogue.

## Key Capabilities

- Analyze execution plans with actual statistics
- Use Query Store for plan regression detection
- Design indexes with included columns
- Optimize parameter sniffing issues

## Technology Standards Applied

- **Query Store**: Performance monitoring and plan management
- **Execution Plans**: Query plan analysis methodology
- **Parameter Sniffing**: Handling plan sensitivity to parameters