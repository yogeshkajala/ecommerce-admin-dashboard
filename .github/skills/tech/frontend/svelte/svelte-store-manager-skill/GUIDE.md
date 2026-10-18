# Svelte Store Manager Skill

> **Category:** Tech Skills > Frontend > Svelte

## Overview

Implements state management in Svelte applications using writable, readable, and derived stores with custom store patterns

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [svelte-store-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
svelte-store-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@svelte-store-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Create writable, readable, and derived stores
- Build custom stores with start/stop logic
- Implement store contracts for cross-component state
- Design persistent stores with localStorage integration

## Technology Standards Applied

- **Svelte Stores**: Official store contract and built-in stores
- **Store Patterns**: Custom store patterns for complex state
- **Auto-subscription**: $-prefix auto-subscription in components