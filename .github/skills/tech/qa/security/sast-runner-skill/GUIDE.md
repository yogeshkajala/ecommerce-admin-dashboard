# Sast Runner Skill

> **Category:** Tech Skills

## Overview

Use when running static application security testing (SAST) to find vulnerabilities in source code.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [sast-runner-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
sast-runner-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@sast-runner` agent from the Independent Agents catalogue.

## Key Capabilities

- Design and execute comprehensive test strategies aligned with project requirements
- Generate test cases covering positive, negative, boundary, and edge scenarios
- Configure and run test frameworks: Jest, pytest, JUnit, xUnit, NUnit, Cypress, Playwright
- Create mock objects, stubs, and fixtures for external dependency isolation

## Industry Standards Applied

- **OWASP Top 10**: Critical web/API security risks and mitigation strategies
- **NIST CSF**: Cybersecurity framework: Identify, Protect, Detect, Respond, Recover
- **CIS Benchmarks**: Configuration security baselines for platforms and cloud services
- **MITRE ATT and CK**: Adversarial tactics, techniques, and procedures knowledge base
