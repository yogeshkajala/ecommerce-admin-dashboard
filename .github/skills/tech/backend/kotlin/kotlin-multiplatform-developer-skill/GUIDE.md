# Kotlin Multiplatform Developer Skill

> **Category:** Tech Skills > Backend > Kotlin

## Overview

Builds cross-platform applications with Kotlin Multiplatform sharing business logic across Android, iOS, web, and desktop targets

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [kotlin-multiplatform-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
kotlin-multiplatform-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@kotlin-multiplatform-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure KMP project with shared and platform modules
- Implement expect/actual for platform-specific code
- Share business logic and data models across targets
- Configure serialization with kotlinx.serialization

## Technology Standards Applied

- **KMP**: Kotlin Multiplatform project structure and patterns
- **Compose Multiplatform**: Shared UI across platforms
- **kotlinx.serialization**: Multiplatform serialization library