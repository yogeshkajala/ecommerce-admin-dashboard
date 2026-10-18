# Oracle Query Optimizer Skill

> **Category:** Tech Skills > Database > Oracle

## Overview

Analyzes and optimizes Oracle queries using execution plans, hints, and optimizer statistics for maximum database performance

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [oracle-query-optimizer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
oracle-query-optimizer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@oracle-query-optimizer` agent from the Independent Agents catalogue.

## Key Capabilities

- Analyze execution plans with DBMS_XPLAN
- Manage optimizer statistics with DBMS_STATS
- Use SQL Plan Baselines for plan stability
- Apply optimizer hints for plan control

## Technology Standards Applied

- **Oracle Optimizer**: Cost-based optimizer configuration and statistics
- **AWR**: Automatic Workload Repository for diagnostics
- **SQL Plan Baselines**: Plan stability management