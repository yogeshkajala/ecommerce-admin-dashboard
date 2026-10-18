# JUnit Extension Developer Skill

> **Category:** Tech Skills > QA > JUnit

## Overview

Creates JUnit 5 extensions for cross-cutting test concerns including test lifecycle callbacks, parameter resolution, and condition evaluation

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [junit-extension-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
junit-extension-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@junit-extension-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Build lifecycle callback extensions
- Implement ParameterResolver for test DI
- Create ExecutionCondition for conditional tests
- Design TestWatcher for test result handling

## Technology Standards Applied

- **JUnit Extensions**: Extension model and callback lifecycle
- **ParameterResolver**: Dependency injection in tests
- **ExecutionCondition**: Conditional test execution patterns