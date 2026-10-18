# Pattern Detector Skill

> **Category:** Domain Skills

## Overview

Use when detecting prompt injection patterns, identifying adversarial prompt techniques, matching known injection signatures, or analyzing inputs for novel attack vectors.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [pattern-detector-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
pattern-detector-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@pattern-detector` agent from the Independent Agents catalogue.

## Key Capabilities

- Analyze business processes and identify improvement opportunities
- Apply domain best practices and industry-standard frameworks
- Assess current state against maturity models and benchmarks
- Generate findings with severity classification and remediation guidance

## Industry Standards Applied

- **SOLID Principles**: Object-oriented design: Single Responsibility, Open/Closed, Liskov, Interface Segregation, Dependency Inversion
- **Domain-Driven Design**: Bounded contexts, aggregates, ubiquitous language
- **Microservice Patterns**: Service decomposition, API gateway, circuit breaker, saga, CQRS
