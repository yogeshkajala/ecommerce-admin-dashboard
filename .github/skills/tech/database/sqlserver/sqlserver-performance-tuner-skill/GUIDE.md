# SQL Server Performance Tuner Skill

> **Category:** Tech Skills > Database > SQL Server

## Overview

Tunes SQL Server configuration including memory, tempdb, MAXDOP, and resource governor for optimal workload performance

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [sqlserver-performance-tuner-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
sqlserver-performance-tuner-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@sqlserver-performance-tuner` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure max server memory and min server memory
- Optimize tempdb file count and sizing
- Set MAXDOP and cost threshold for parallelism
- Configure Resource Governor for workload isolation

## Technology Standards Applied

- **SQL Server Tuning**: Server configuration best practices
- **tempdb**: tempdb optimization guidelines
- **Resource Governor**: Workload isolation and management