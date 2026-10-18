# PWA Offline Specialist Skill

> **Category:** Tech Skills > Frontend > PWA

## Overview

Implements offline-first functionality for PWAs including offline data storage, conflict resolution, and progressive enhancement

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [pwa-offline-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
pwa-offline-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@pwa-offline-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Implement IndexedDB storage for offline data
- Design conflict resolution for offline edits
- Build offline queue with retry and reconciliation
- Create offline UI indicators and fallback pages

## Technology Standards Applied

- **IndexedDB**: Structured storage for offline web applications
- **Background Sync**: Deferred sync for offline operations
- **Progressive Enhancement**: Graceful feature degradation patterns