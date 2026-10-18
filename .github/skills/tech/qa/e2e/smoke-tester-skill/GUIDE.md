# Smoke Tester Skill

> **Category:** Tech Skills

## Overview

Use when running smoke tests on critical business flows immediately after deployment.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [smoke-tester-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
smoke-tester-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@smoke-tester` agent from the Independent Agents catalogue.

## Key Capabilities

- Design and execute comprehensive test strategies aligned with project requirements
- Generate test cases covering positive, negative, boundary, and edge scenarios
- Configure and run test frameworks: Jest, pytest, JUnit, xUnit, NUnit, Cypress, Playwright
- Create mock objects, stubs, and fixtures for external dependency isolation

## Industry Standards Applied

- **ISTQB Foundation**: Test design techniques, test levels, and test process framework
- **ISO 25010**: Software quality model: functional suitability, reliability, usability
- **OWASP Testing Guide**: Security testing methodology for web applications
