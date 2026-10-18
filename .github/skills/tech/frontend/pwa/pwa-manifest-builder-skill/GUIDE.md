# PWA Manifest Builder Skill

> **Category:** Tech Skills > Frontend > PWA

## Overview

Creates and configures Web App Manifests for PWAs with proper icons, display modes, shortcuts, and installation behavior

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [pwa-manifest-builder-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
pwa-manifest-builder-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@pwa-manifest-builder` agent from the Independent Agents catalogue.

## Key Capabilities

- Create manifest.json with proper icon sets
- Configure display modes: standalone, fullscreen, minimal-ui
- Implement app shortcuts for quick actions
- Set up share target for web share API

## Technology Standards Applied

- **Web App Manifest**: W3C specification for manifest files
- **Maskable Icons**: Adaptive icon specification for Android
- **Lighthouse PWA**: PWA audit criteria for installability