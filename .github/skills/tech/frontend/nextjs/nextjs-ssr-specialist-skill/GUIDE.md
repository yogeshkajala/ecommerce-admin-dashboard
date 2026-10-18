# Next.js SSR Specialist Skill

> **Category:** Tech Skills > Frontend > Next.js

## Overview

Implements server-side rendering strategies in Next.js with streaming, caching, and revalidation for optimal performance

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [nextjs-ssr-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
nextjs-ssr-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@nextjs-ssr-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure streaming SSR with Suspense boundaries
- Implement ISR with time-based and on-demand revalidation
- Set up fetch caching with proper revalidation strategies
- Handle dynamic rendering with cookies and headers

## Technology Standards Applied

- **Data Fetching**: fetch API with cache and revalidation options
- **ISR**: Incremental Static Regeneration patterns
- **Streaming**: React Suspense-based streaming SSR