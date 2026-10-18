# Go API Builder Skill

> **Category:** Tech Skills > Backend > Go

## Overview

Builds RESTful APIs with Go using standard library, Gin, or Echo frameworks with proper routing, middleware, and error handling

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [go-api-builder-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
go-api-builder-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@go-api-builder` agent from the Independent Agents catalogue.

## Key Capabilities

- Build APIs with net/http, Gin, or Echo
- Implement middleware for auth, logging, and CORS
- Design structured error responses with proper status codes
- Configure request validation with struct tags

## Technology Standards Applied

- **Go HTTP Patterns**: Standard library HTTP server patterns
- **Gin Framework**: Gin routing and middleware conventions
- **OpenAPI**: API documentation generation