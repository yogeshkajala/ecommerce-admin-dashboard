# Pytest Mock Specialist Skill

> **Category:** Tech Skills > QA > Pytest

## Overview

Implements mocking strategies with pytest-mock and unittest.mock including patching, fixtures, and mock configuration

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [pytest-mock-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
pytest-mock-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@pytest-mock-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Mock with pytest-mock mocker fixture
- Use monkeypatch for env vars and attributes
- Implement autospec mocking for safety
- Configure mock return values and side effects

## Technology Standards Applied

- **pytest-mock**: Mocker fixture and patching patterns
- **monkeypatch**: Environment and attribute manipulation
- **autospec**: Spec-based mock safety