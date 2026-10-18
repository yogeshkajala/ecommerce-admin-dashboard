# Jest Config Specialist Skill

> **Category:** Tech Skills > QA > Jest

## Overview

Configures Jest for complex project setups including monorepos, TypeScript, module aliases, and custom transformers

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [jest-config-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
jest-config-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@jest-config-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure Jest with TypeScript via ts-jest or SWC
- Set up module name mappers for path aliases
- Implement custom transformers for CSS, images
- Configure Jest projects for monorepo testing

## Technology Standards Applied

- **Jest Configuration**: jest.config options and patterns
- **ts-jest**: TypeScript integration for Jest
- **Module Resolution**: Path alias and transformer configuration