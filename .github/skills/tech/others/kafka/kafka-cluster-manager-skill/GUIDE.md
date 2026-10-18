# Kafka Cluster Manager Skill

> **Category:** Tech Skills > Others > Apache Kafka

## Overview

Manages Kafka clusters including topic configuration, partition management, and cluster monitoring for production operations

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [kafka-cluster-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
kafka-cluster-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@kafka-cluster-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure topics with proper partition and replication settings
- Manage partition reassignment for balanced distribution
- Monitor cluster health with JMX metrics
- Configure log retention and compaction

## Technology Standards Applied

- **Kafka Operations**: Cluster management best practices
- **Topic Configuration**: Partition and retention settings
- **Monitoring**: JMX metrics and monitoring tools