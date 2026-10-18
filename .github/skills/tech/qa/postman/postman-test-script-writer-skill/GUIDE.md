# Postman Test Script Writer Skill

> **Category:** Tech Skills > QA > Postman

## Overview

Writes Postman test scripts with pm.test assertions for response validation, schema checking, and workflow testing

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [postman-test-script-writer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
postman-test-script-writer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@postman-test-script-writer` agent from the Independent Agents catalogue.

## Key Capabilities

- Write pm.test assertions for responses
- Implement JSON schema validation
- Create pre-request scripts for token refresh
- Chain requests with variable extraction

## Technology Standards Applied

- **Test Scripts**: pm.test assertion patterns
- **Schema Validation**: JSON schema checking in tests
- **Pre-Request**: Dynamic data generation and auth