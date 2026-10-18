# Kafka Consumer Specialist Skill

> **Category:** Tech Skills > Others > Apache Kafka

## Overview

Implements Kafka consumers with proper group management, offset handling, and rebalancing strategies for reliable message consumption

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [kafka-consumer-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
kafka-consumer-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@kafka-consumer-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure consumer groups with proper settings
- Implement manual and automatic offset commits
- Handle consumer rebalancing with cooperative strategy
- Implement idempotent message processing

## Technology Standards Applied

- **Consumer Config**: Key consumer configuration parameters
- **Offset Management**: Commit strategies and semantics
- **Rebalancing**: Consumer group rebalancing protocols