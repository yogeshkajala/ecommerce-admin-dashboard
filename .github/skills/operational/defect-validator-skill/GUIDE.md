# Defect Validator Skill

> **Category:** Tech Skills

## Overview

Use when validating defect fixes, running targeted verification tests, executing regression suites, or confirming fix effectiveness across environments.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [defect-validator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
defect-validator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@defect-validator` agent from the Independent Agents catalogue.

## Key Capabilities

- Design and execute comprehensive test strategies aligned with project requirements
- Generate test cases covering positive, negative, boundary, and edge scenarios
- Configure and run test frameworks: Jest, pytest, JUnit, xUnit, NUnit, Cypress, Playwright
- Create mock objects, stubs, and fixtures for external dependency isolation

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
