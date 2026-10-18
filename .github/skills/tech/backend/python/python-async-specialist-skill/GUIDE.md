# Python Async Specialist Skill

> **Category:** Tech Skills > Backend > Python

## Overview

Implements asynchronous Python applications with asyncio, aiohttp, and async generators for high-concurrency I/O operations

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [python-async-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
python-async-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@python-async-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Build asyncio event loops with proper lifecycle
- Implement async context managers and iterators
- Create async HTTP clients with connection pooling
- Design task groups and structured concurrency

## Technology Standards Applied

- **asyncio Documentation**: Official asyncio patterns and best practices
- **Structured Concurrency**: TaskGroup patterns for safe task management
- **aiohttp**: Async HTTP client/server patterns