# Domain Identifier Skill

> **Category:** Generic Skills

## Overview

Use when identifying bounded contexts and domain boundaries in monolithic applications using DDD principles.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [domain-identifier-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
domain-identifier-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@domain-identifier` agent from the Independent Agents catalogue.

## Key Capabilities

- Analyze complex systems and decompose into manageable components
- Design solutions following established patterns and conventions
- Generate structured artifacts with consistent formatting and quality
- Validate outputs against acceptance criteria and quality gates

## Industry Standards Applied

- **SOLID Principles**: Object-oriented design: Single Responsibility, Open/Closed, Liskov, Interface Segregation, Dependency Inversion
- **Domain-Driven Design**: Bounded contexts, aggregates, ubiquitous language
- **Microservice Patterns**: Service decomposition, API gateway, circuit breaker, saga, CQRS
