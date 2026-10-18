# Cypress Plugin Developer Skill

> **Category:** Tech Skills > QA > Cypress

## Overview

Creates Cypress plugins for extending framework capabilities with custom tasks, preprocessors, and event handlers

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [cypress-plugin-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
cypress-plugin-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@cypress-plugin-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Build plugins with setupNodeEvents
- Implement custom cy.task handlers
- Create preprocessors for TypeScript and bundling
- Design browser launch handlers

## Technology Standards Applied

- **Cypress Plugins**: Plugin API and event handlers
- **Tasks**: Node.js task execution from tests
- **Preprocessors**: Test file compilation and bundling