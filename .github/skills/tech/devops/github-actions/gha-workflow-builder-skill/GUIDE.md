# GitHub Actions Workflow Builder Skill

> **Category:** Tech Skills > DevOps > GitHub Actions

## Overview

Creates GitHub Actions workflows for CI/CD automation with proper trigger configuration, job design, and artifact management

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [gha-workflow-builder-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
gha-workflow-builder-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@gha-workflow-builder` agent from the Independent Agents catalogue.

## Key Capabilities

- Design workflows with proper trigger events
- Configure jobs with dependency chains
- Implement matrix strategies for multi-platform builds
- Manage artifacts and caching between jobs

## Technology Standards Applied

- **GitHub Actions**: Workflow syntax and best practices
- **Matrix Strategy**: Multi-platform and multi-version builds
- **Caching**: actions/cache for dependency optimization