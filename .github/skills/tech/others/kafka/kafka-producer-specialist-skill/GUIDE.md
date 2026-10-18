# Kafka Producer Specialist Skill

> **Category:** Tech Skills > Others > Apache Kafka

## Overview

Implements Kafka producers with proper partitioning, serialization, and delivery guarantees for reliable message publishing

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [kafka-producer-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
kafka-producer-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@kafka-producer-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure producers with proper acknowledgement settings
- Implement custom partitioners for message routing
- Configure serialization with Avro or Protobuf
- Handle producer errors and retries

## Technology Standards Applied

- **Producer Config**: Key producer configuration parameters
- **Delivery Semantics**: At-least-once and exactly-once delivery
- **Serialization**: Avro, Protobuf, JSON schema patterns