# Oracle Performance Tuner Skill

> **Category:** Tech Skills > Database > Oracle

## Overview

Tunes Oracle database performance through SGA/PGA configuration, optimizer settings, and AWR-based diagnostics for production workloads

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [oracle-performance-tuner-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
oracle-performance-tuner-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@oracle-performance-tuner` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure SGA and PGA for optimal memory usage
- Analyze AWR and ADDM reports for recommendations
- Tune buffer cache and shared pool sizes
- Configure automatic memory management

## Technology Standards Applied

- **AWR**: Automatic Workload Repository for diagnostics
- **ADDM**: Automatic Database Diagnostic Monitor
- **Memory Management**: SGA, PGA, and AMM configuration