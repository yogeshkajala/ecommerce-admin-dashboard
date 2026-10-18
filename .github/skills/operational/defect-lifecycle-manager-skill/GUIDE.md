# Defect Lifecycle Manager Skill

> **Category:** Tech Skills

## Overview

Use when managing the full defect lifecycle: detection, triage, root cause analysis, fix implementation, validation, and regression testing with severity-based SLAs.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [defect-lifecycle-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
defect-lifecycle-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@defect-lifecycle-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Design and execute comprehensive test strategies aligned with project requirements
- Generate test cases covering positive, negative, boundary, and edge scenarios
- Configure and run test frameworks: Jest, pytest, JUnit, xUnit, NUnit, Cypress, Playwright
- Create mock objects, stubs, and fixtures for external dependency isolation

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
