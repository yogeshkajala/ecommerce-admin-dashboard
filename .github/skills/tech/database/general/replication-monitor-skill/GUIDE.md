# Replication Monitor Skill

> **Category:** Tech Skills

## Overview

Monitor database replication lag, sync status, failover readiness, and replica health for high-availability database deployments.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [replication-monitor-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
replication-monitor-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@replication-monitor` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure CI/CD pipelines with build, test, scan, and deploy stages
- Execute deployment strategies: rolling, blue-green, canary, and progressive rollout
- Manage environment promotion workflows with approval gates
- Validate deployment health through automated smoke tests and metric checks

## Industry Standards Applied

- **ACID Principles**: Transaction guarantees: Atomicity, Consistency, Isolation, Durability
- **CAP Theorem**: Distributed database trade-offs: Consistency, Availability, Partition tolerance
- **Database Normalization**: Normal forms (1NF-5NF) for relational data integrity
