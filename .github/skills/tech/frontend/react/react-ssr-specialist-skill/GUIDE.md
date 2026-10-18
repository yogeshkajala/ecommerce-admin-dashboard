# React SSR Specialist Skill

> **Category:** Tech Skills > Frontend > React

## Overview

Implements server-side rendering for React applications with hydration, streaming, and server component patterns

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [react-ssr-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
react-ssr-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@react-ssr-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Implement SSR with renderToString and renderToPipeableStream
- Configure streaming SSR with Suspense boundaries
- Handle hydration mismatches and client-only rendering
- Implement server components with proper boundaries

## Technology Standards Applied

- **React Server Components**: Server/client component boundary patterns
- **Streaming SSR**: React 18 streaming with renderToPipeableStream
- **SEO Requirements**: Meta tags and structured data for SSR pages