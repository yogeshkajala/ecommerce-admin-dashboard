# Pytest Plugin Developer Skill

> **Category:** Tech Skills > QA > Pytest

## Overview

Creates pytest plugins for extending test framework functionality with hooks, fixtures, and custom markers

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [pytest-plugin-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
pytest-plugin-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@pytest-plugin-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Build plugins with pytest hook specifications
- Create custom markers with validation
- Implement conftest-based local plugins
- Package plugins for distribution on PyPI

## Technology Standards Applied

- **Pytest Plugins**: Plugin development and hook specification
- **Custom Markers**: Test categorization and filtering
- **Entry Points**: Plugin registration and distribution