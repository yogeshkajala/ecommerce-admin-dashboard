# GitHub Actions Composite Action Developer Skill

> **Category:** Tech Skills > DevOps > GitHub Actions

## Overview

Creates reusable composite actions and JavaScript actions for shared CI/CD logic across GitHub repositories

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [gha-composite-action-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
gha-composite-action-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@gha-composite-action-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Build composite actions with inputs and outputs
- Create JavaScript/TypeScript actions with toolkit
- Define proper action metadata with action.yml
- Implement input validation and error handling

## Technology Standards Applied

- **Action Metadata**: action.yml specification and patterns
- **Composite Actions**: Multi-step reusable action patterns
- **Action Toolkit**: @actions/core and @actions/github packages