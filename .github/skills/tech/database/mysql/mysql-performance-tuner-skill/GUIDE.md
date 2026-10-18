# MySQL Performance Tuner Skill

> **Category:** Tech Skills > Database > MySQL

## Overview

Tunes MySQL server configuration including InnoDB settings, connection pool, and memory allocation for optimal workload performance

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [mysql-performance-tuner-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
mysql-performance-tuner-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@mysql-performance-tuner` agent from the Independent Agents catalogue.

## Key Capabilities

- Tune InnoDB buffer pool size and instances
- Configure redo log size and flushing strategy
- Optimize connection pool and thread cache
- Set up Performance Schema for monitoring

## Technology Standards Applied

- **InnoDB Tuning**: Buffer pool, redo log, and flush configuration
- **Connection Management**: Thread pool and connection limit settings
- **Performance Schema**: Server monitoring and diagnostics framework