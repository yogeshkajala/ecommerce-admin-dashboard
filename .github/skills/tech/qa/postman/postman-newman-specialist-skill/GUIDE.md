# Postman Newman Specialist Skill

> **Category:** Tech Skills > QA > Postman

## Overview

Runs Postman collections in CI/CD with Newman including environment configuration, reporting, and parallel execution

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [postman-newman-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
postman-newman-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@postman-newman-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Run collections with Newman CLI
- Configure environment and data files
- Generate reports with HTML and JUnit reporters
- Implement parallel execution strategies

## Technology Standards Applied

- **Newman CLI**: Command-line collection runner
- **Reporters**: Newman report generation
- **CI Integration**: Newman in CI/CD pipelines