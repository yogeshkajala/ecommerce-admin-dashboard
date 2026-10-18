# Microservice Communication Specialist Skill

> **Category:** Tech Skills > Others > Microservices

## Overview

Implements inter-service communication patterns including synchronous REST/gRPC and asynchronous messaging with proper resilience

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [microservice-communication-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
microservice-communication-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@microservice-communication-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Implement sync communication with REST or gRPC
- Design async communication with message queues
- Add circuit breakers with resilience4j or Polly
- Implement retry with exponential backoff

## Technology Standards Applied

- **Communication Patterns**: Sync vs async communication selection
- **Circuit Breaker**: Resilience pattern for cascading failure prevention
- **Saga Pattern**: Distributed transaction management