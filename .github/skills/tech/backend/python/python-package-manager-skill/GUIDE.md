# Python Package Manager Skill

> **Category:** Tech Skills > Backend > Python

## Overview

Manages Python project dependencies with pip, poetry, or uv including virtual environments, lockfiles, and package publishing

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [python-package-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
python-package-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@python-package-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure pyproject.toml with proper metadata
- Manage dependencies with poetry or uv
- Set up virtual environments with proper isolation
- Generate and maintain lockfiles for reproducibility

## Technology Standards Applied

- **PEP 621**: Project metadata in pyproject.toml
- **Poetry**: Dependency management and packaging
- **uv**: Fast Python package installer and resolver