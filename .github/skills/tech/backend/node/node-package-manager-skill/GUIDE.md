# Node.js Package Manager Skill

> **Category:** Tech Skills > Backend > Node.js

## Overview

Manages Node.js dependencies with npm, yarn, or pnpm including workspace configuration, lockfile management, and security auditing

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [node-package-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
node-package-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@node-package-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure npm/pnpm workspaces for monorepos
- Manage lockfile integrity and reproducible installs
- Resolve dependency version conflicts
- Run security audits with npm audit

## Technology Standards Applied

- **npm Best Practices**: npm configuration and security guidelines
- **pnpm Workspaces**: Efficient monorepo dependency management
- **Semver**: Semantic versioning for package publishing