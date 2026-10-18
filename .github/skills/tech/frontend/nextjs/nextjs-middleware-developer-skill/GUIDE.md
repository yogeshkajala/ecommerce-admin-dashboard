# Next.js Middleware Developer Skill

> **Category:** Tech Skills > Frontend > Next.js

## Overview

Creates Next.js edge middleware for request processing including authentication, internationalization, and A/B testing at the edge

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [nextjs-middleware-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
nextjs-middleware-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@nextjs-middleware-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Build edge middleware with NextRequest/NextResponse
- Implement authentication token validation at the edge
- Configure locale detection and URL rewriting
- Set up feature flags and A/B testing with cookies

## Technology Standards Applied

- **Edge Middleware**: Middleware API with matchers and edge runtime
- **Edge Runtime**: Edge runtime limitations and available APIs
- **Matcher Config**: Route matching patterns for middleware