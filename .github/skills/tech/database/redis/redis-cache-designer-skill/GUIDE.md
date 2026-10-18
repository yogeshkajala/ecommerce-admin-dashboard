# Redis Cache Designer Skill

> **Category:** Tech Skills > Database > Redis

## Overview

Designs caching strategies with Redis including cache patterns, eviction policies, and TTL management for application performance

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [redis-cache-designer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
redis-cache-designer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@redis-cache-designer` agent from the Independent Agents catalogue.

## Key Capabilities

- Design cache-aside, write-through, write-behind patterns
- Configure TTL strategies for different data types
- Implement cache warming and pre-loading
- Set up eviction policies: LRU, LFU, volatile

## Technology Standards Applied

- **Caching Patterns**: Cache-aside, write-through pattern selection
- **Eviction Policies**: LRU, LFU, and volatile key eviction
- **Redis Memory**: Memory optimization and maxmemory configuration