# Nginx Performance Tuner Skill

> **Category:** Tech Skills > Others > Nginx

## Overview

Optimizes Nginx performance with worker processes, connection handling, caching, and compression for high-throughput delivery

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [nginx-performance-tuner-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
nginx-performance-tuner-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@nginx-performance-tuner` agent from the Independent Agents catalogue.

## Key Capabilities

- Tune worker processes and connections
- Configure proxy and static file caching
- Implement gzip and Brotli compression
- Optimize buffer sizes for response handling

## Technology Standards Applied

- **Nginx Performance**: Performance tuning guidelines
- **Caching**: Proxy and static content caching
- **Compression**: gzip and Brotli configuration