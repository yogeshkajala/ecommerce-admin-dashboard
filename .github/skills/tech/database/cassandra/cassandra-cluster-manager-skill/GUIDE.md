# Cassandra Cluster Manager Skill

> **Category:** Tech Skills > Database > Cassandra

## Overview

Deploys and manages Cassandra clusters including node operations, compaction strategies, and repair management for production stability

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [cassandra-cluster-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
cassandra-cluster-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@cassandra-cluster-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Deploy multi-datacenter Cassandra clusters
- Manage node operations with nodetool
- Configure compaction strategies per table
- Schedule repairs for data consistency

## Technology Standards Applied

- **Cassandra Operations**: Cluster management and nodetool operations
- **Compaction**: Strategy selection for workload types
- **Repair**: Anti-entropy repair scheduling