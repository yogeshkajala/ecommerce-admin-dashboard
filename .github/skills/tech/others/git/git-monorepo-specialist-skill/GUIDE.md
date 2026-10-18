# Git Monorepo Specialist Skill

> **Category:** Tech Skills > Others > Git

## Overview

Manages Git monorepos with proper tooling, selective checkout, and CI/CD integration for large-scale single-repository development

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [git-monorepo-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
git-monorepo-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@git-monorepo-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure sparse checkout for selective work
- Implement path-based CI/CD triggers
- Use Git LFS for large file management
- Configure Nx or Turborepo for monorepo builds

## Technology Standards Applied

- **Monorepo**: Monorepo management patterns and tools
- **Sparse Checkout**: Selective directory checkout for performance
- **Build Caching**: Nx and Turborepo build optimization