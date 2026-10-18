# Pattern Learner Skill

> **Category:** Domain Skills

## Overview

Learn from incident outcomes to create new symptom patterns, improve match accuracy, and expand the automated remediation knowledge base.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [pattern-learner-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
pattern-learner-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@pattern-learner` agent from the Independent Agents catalogue.

## Key Capabilities

- Classify incidents by severity using impact, urgency, and blast radius assessment
- Execute structured triage with symptom analysis and correlation
- Perform root cause analysis through 5-Why, fishbone, and fault tree methods
- Execute containment and remediation actions with safety guardrails

## Industry Standards Applied

- **SOLID Principles**: Object-oriented design: Single Responsibility, Open/Closed, Liskov, Interface Segregation, Dependency Inversion
- **Domain-Driven Design**: Bounded contexts, aggregates, ubiquitous language
- **Microservice Patterns**: Service decomposition, API gateway, circuit breaker, saga, CQRS
