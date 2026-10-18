# Python Celery Specialist Skill

> **Category:** Tech Skills > Backend > Python

## Overview

Implements distributed task processing with Celery including task design, broker configuration, result backends, and workflow orchestration

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [python-celery-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
python-celery-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@python-celery-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure Celery with RabbitMQ or Redis broker
- Design idempotent tasks with proper retry logic
- Build task workflows with chains, groups, and chords
- Monitor tasks with Flower dashboard

## Technology Standards Applied

- **Celery Best Practices**: Task design and configuration guidelines
- **Task Patterns**: Idempotency, retry, and error handling patterns
- **Workflow Primitives**: Chain, group, chord, and callback patterns