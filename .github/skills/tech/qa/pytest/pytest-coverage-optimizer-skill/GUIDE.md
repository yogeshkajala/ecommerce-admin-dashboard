# Pytest Coverage Optimizer Skill

> **Category:** Tech Skills > QA > Pytest

## Overview

Configures and optimizes pytest code coverage with pytest-cov including branch coverage, threshold enforcement, and reporting

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [pytest-coverage-optimizer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
pytest-coverage-optimizer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@pytest-coverage-optimizer` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure pytest-cov with proper source paths
- Enable branch coverage for decision coverage
- Set coverage thresholds for CI enforcement
- Generate HTML and XML coverage reports

## Technology Standards Applied

- **pytest-cov**: Coverage plugin configuration
- **Branch Coverage**: Decision coverage measurement
- **Coverage.py**: Underlying coverage tool settings