# Python Type Checker Skill

> **Category:** Tech Skills > Backend > Python

## Overview

Implements static type checking in Python with mypy, pyright, and type annotations for improved code reliability and IDE support

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [python-type-checker-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
python-type-checker-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@python-type-checker` agent from the Independent Agents catalogue.

## Key Capabilities

- Add type annotations to functions and classes
- Configure mypy with strict checking options
- Create Protocol classes for structural typing
- Implement generic types with TypeVar and ParamSpec

## Technology Standards Applied

- **PEP 484**: Type hints specification for Python
- **mypy Documentation**: Static type checking configuration and patterns
- **pyright**: Fast type checker with strict mode