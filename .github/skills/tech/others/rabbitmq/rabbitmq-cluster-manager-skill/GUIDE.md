# RabbitMQ Cluster Manager Skill

> **Category:** Tech Skills > Others > RabbitMQ

## Overview

Manages RabbitMQ clusters including node management, quorum queues, and high availability configuration for production deployments

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [rabbitmq-cluster-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
rabbitmq-cluster-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@rabbitmq-cluster-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure RabbitMQ clusters with multiple nodes
- Implement quorum queues for data safety
- Handle network partitions with proper strategies
- Configure cluster monitoring with Prometheus

## Technology Standards Applied

- **Clustering**: RabbitMQ clustering architecture
- **Quorum Queues**: Raft-based queue replication
- **Partitions**: Network partition handling strategies