# Git Hooks Specialist Skill

> **Category:** Tech Skills > Others > Git

## Overview

Implements Git hooks for commit validation, code formatting, and CI/CD integration using Husky and lint-staged

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [git-hooks-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
git-hooks-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@git-hooks-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure Husky for Git hook management
- Implement pre-commit hooks with lint-staged
- Validate commit messages with commitlint
- Set up pre-push hooks for test execution

## Technology Standards Applied

- **Husky**: Git hook management for Node.js projects
- **lint-staged**: Running linters on staged files
- **Conventional Commits**: Commit message convention enforcement