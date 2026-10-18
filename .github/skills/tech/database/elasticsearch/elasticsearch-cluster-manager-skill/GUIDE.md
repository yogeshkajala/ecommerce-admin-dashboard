# Elasticsearch Cluster Manager Skill

> **Category:** Tech Skills > Database > Elasticsearch

## Overview

Manages Elasticsearch clusters including node configuration, shard allocation, and cluster health monitoring for production stability

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [elasticsearch-cluster-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
elasticsearch-cluster-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@elasticsearch-cluster-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure cluster nodes with proper roles
- Manage shard allocation and routing
- Monitor cluster health with _cluster/health API
- Configure cross-cluster replication

## Technology Standards Applied

- **Cluster Configuration**: Node roles and discovery settings
- **Shard Allocation**: Allocation awareness and filtering
- **Recovery**: Cluster recovery and resilience settings