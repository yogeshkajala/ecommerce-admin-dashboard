# RabbitMQ Queue Specialist Skill

> **Category:** Tech Skills > Others > RabbitMQ

## Overview

Configures RabbitMQ queues with proper durability, TTL, dead letter handling, and consumer management for reliable messaging

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [rabbitmq-queue-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
rabbitmq-queue-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@rabbitmq-queue-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure durable queues with proper properties
- Implement dead letter exchanges and queues
- Set TTL and max-length for queue management
- Configure consumer prefetch for flow control

## Technology Standards Applied

- **Queue Configuration**: Queue properties and durability settings
- **Dead Letters**: DLX configuration and retry patterns
- **Consumer**: Prefetch and acknowledgement patterns