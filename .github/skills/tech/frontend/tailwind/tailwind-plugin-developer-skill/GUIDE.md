# Tailwind Plugin Developer Skill

> **Category:** Tech Skills > Frontend > Tailwind CSS

## Overview

Creates custom Tailwind CSS plugins for extending the framework with new utilities, components, and variant modifiers

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [tailwind-plugin-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
tailwind-plugin-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@tailwind-plugin-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Build utility plugins with addUtilities API
- Create component plugins with addComponents API
- Implement custom variant modifiers
- Design theme-aware plugins with theme function

## Technology Standards Applied

- **Plugin API**: Official Tailwind plugin authoring documentation
- **Utility Plugins**: Adding custom utilities with matchUtilities
- **Theme Integration**: Accessing and extending theme in plugins