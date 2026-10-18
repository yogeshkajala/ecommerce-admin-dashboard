# TypeScript Config Optimizer Skill

> **Category:** Tech Skills > Frontend > TypeScript

## Overview

Optimizes TypeScript compiler configuration for project needs including strict mode, path aliases, project references, and build performance

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [typescript-config-optimizer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
typescript-config-optimizer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@typescript-config-optimizer` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure strict mode with appropriate strictness levels
- Set up path aliases with proper module resolution
- Implement project references for monorepo builds
- Optimize incremental builds with tsBuildInfo

## Technology Standards Applied

- **TSConfig Reference**: Official compiler option documentation
- **Project References**: Monorepo build optimization with references
- **Module Resolution**: Node, bundler, and classic resolution strategies