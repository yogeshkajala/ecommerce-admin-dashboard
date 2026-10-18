# Cassandra Replication Specialist Skill

> **Category:** Tech Skills > Database > Cassandra

## Overview

Configures Cassandra replication strategies including NetworkTopologyStrategy, consistency levels, and multi-datacenter replication

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [cassandra-replication-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
cassandra-replication-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@cassandra-replication-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure NetworkTopologyStrategy with proper RF per DC
- Choose consistency levels for read/write balance
- Implement multi-DC replication for disaster recovery
- Handle consistency across datacenters

## Technology Standards Applied

- **Replication**: Replication strategy and factor selection
- **Consistency Levels**: Read/write consistency trade-offs
- **Multi-DC**: Cross-datacenter replication patterns