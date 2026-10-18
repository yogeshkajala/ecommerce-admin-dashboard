# PWA Service Worker Developer Skill

> **Category:** Tech Skills > Frontend > PWA

## Overview

Develops service workers for Progressive Web Apps with caching strategies, background sync, and lifecycle management

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [pwa-service-worker-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
pwa-service-worker-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@pwa-service-worker-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Implement cache-first, network-first, and stale-while-revalidate strategies
- Configure precaching for critical application assets
- Handle service worker lifecycle with install, activate, and fetch events
- Implement background sync for offline form submissions

## Technology Standards Applied

- **Service Worker API**: Web API specification for service workers
- **Workbox**: Google's service worker library for caching strategies
- **Cache API**: Cache storage patterns and size management