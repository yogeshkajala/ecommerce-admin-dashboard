# Pytest Parameterized Tester Skill

> **Category:** Tech Skills > QA > Pytest

## Overview

Implements parameterized tests with pytest.mark.parametrize including indirect parametrize, fixture parametrization, and custom IDs

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [pytest-parameterized-tester-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
pytest-parameterized-tester-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@pytest-parameterized-tester` agent from the Independent Agents catalogue.

## Key Capabilities

- Use @pytest.mark.parametrize with multiple parameters
- Implement indirect parametrization through fixtures
- Generate custom test IDs for readability
- Combine parametrize markers for cross-product

## Technology Standards Applied

- **Parametrize**: pytest parametrization patterns
- **Indirect**: Indirect fixture parametrization
- **Custom IDs**: Readable test identification