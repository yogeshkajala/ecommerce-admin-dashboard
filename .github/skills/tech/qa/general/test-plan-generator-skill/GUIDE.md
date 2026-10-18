# Test Plan Generator Skill

> **Category:** Tech Skills

## Overview

Use when generating targeted test plans covering areas affected by the upgrade including regression, compatibility, and performance tests.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [test-plan-generator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
test-plan-generator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@test-plan-generator` agent from the Independent Agents catalogue.

## Key Capabilities

- Design and execute comprehensive test strategies aligned with project requirements
- Generate test cases covering positive, negative, boundary, and edge scenarios
- Configure and run test frameworks: Jest, pytest, JUnit, xUnit, NUnit, Cypress, Playwright
- Create mock objects, stubs, and fixtures for external dependency isolation

## Industry Standards Applied

- **ISTQB Foundation**: Test design techniques, test levels, and test process framework
- **ISO 25010**: Software quality model: functional suitability, reliability, usability
- **OWASP Testing Guide**: Security testing methodology for web applications
