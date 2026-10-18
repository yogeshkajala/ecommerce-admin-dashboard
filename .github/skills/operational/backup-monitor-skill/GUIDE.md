# Backup Monitor Skill

> **Category:** Tech Skills

## Overview

Monitor database backup status, validate backup freshness and integrity, and assess recovery readiness for all database instances.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [backup-monitor-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
backup-monitor-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@backup-monitor` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure telemetry collection across metrics, logs, and distributed traces
- Establish baseline metrics and detect anomalies using statistical analysis
- Correlate signals across multiple data sources for root cause identification
- Define and tune alert rules with severity thresholds and noise reduction

## Industry Standards Applied

- **ACID Principles**: Transaction guarantees: Atomicity, Consistency, Isolation, Durability
- **CAP Theorem**: Distributed database trade-offs: Consistency, Availability, Partition tolerance
- **Database Normalization**: Normal forms (1NF-5NF) for relational data integrity
