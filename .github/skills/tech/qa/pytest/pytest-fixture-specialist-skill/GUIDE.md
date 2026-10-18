# Pytest Fixture Specialist Skill

> **Category:** Tech Skills > QA > Pytest

## Overview

Creates pytest fixtures for test setup and teardown with proper scoping, parameterization, and dependency injection patterns

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [pytest-fixture-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
pytest-fixture-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@pytest-fixture-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Create fixtures with proper scope: function, class, module, session
- Build fixture factories for configurable test data
- Implement yield fixtures for setup/teardown
- Use conftest.py for shared fixtures

## Technology Standards Applied

- **Pytest Fixtures**: Fixture design and scoping patterns
- **conftest.py**: Fixture sharing and organization
- **Fixture Factories**: Configurable test data generation