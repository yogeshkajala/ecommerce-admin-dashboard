# Coexistence Designer Skill

> **Category:** Domain Skills

## Overview

Use when designing coexistence patterns (strangler fig, parallel run) for incremental legacy migration.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [coexistence-designer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
coexistence-designer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@coexistence-designer` agent from the Independent Agents catalogue.

## Key Capabilities

- Assess source systems for migration readiness and complexity
- Classify migration strategy using 7R framework
- Plan migration waves with dependency ordering and cutover scheduling
- Execute data migration with integrity verification and rollback readiness

## Industry Standards Applied

- **SOLID Principles**: Object-oriented design: Single Responsibility, Open/Closed, Liskov, Interface Segregation, Dependency Inversion
- **Domain-Driven Design**: Bounded contexts, aggregates, ubiquitous language
- **Microservice Patterns**: Service decomposition, API gateway, circuit breaker, saga, CQRS
