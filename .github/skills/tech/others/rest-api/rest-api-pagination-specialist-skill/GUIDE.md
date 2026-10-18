# REST API Pagination Specialist Skill

> **Category:** Tech Skills > Others > REST API

## Overview

Implements API pagination with offset, cursor, and keyset strategies with proper response formatting and link headers

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [rest-api-pagination-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
rest-api-pagination-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@rest-api-pagination-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Implement offset-based pagination
- Design cursor-based pagination for consistency
- Implement keyset pagination for performance
- Configure response with pagination metadata

## Technology Standards Applied

- **Cursor Pagination**: Cursor-based pagination patterns
- **Offset Pagination**: Offset and limit pagination patterns
- **RFC 8288**: Web Linking for pagination