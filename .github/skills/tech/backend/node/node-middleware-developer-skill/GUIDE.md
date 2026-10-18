# Node.js Middleware Developer Skill

> **Category:** Tech Skills > Backend > Node.js

## Overview

Creates Express and Fastify middleware for request processing including authentication, validation, rate limiting, and error handling

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [node-middleware-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
node-middleware-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@node-middleware-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Build Express middleware with proper next() handling
- Create Fastify plugins with proper encapsulation
- Implement request validation with Joi or Zod
- Add rate limiting with sliding window algorithm

## Technology Standards Applied

- **Express Middleware**: Express middleware patterns and conventions
- **Fastify Plugins**: Fastify encapsulated plugin system
- **OWASP**: Input validation and sanitization standards