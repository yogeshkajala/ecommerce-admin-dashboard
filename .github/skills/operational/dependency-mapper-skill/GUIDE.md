# Dependency Mapper Skill

> **Category:** Tech Skills

## Overview

Use when mapping workload dependencies, communication patterns, and data flows to define migration groups.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [dependency-mapper-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
dependency-mapper-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@dependency-mapper` agent from the Independent Agents catalogue.

## Key Capabilities

- Execute static analysis using language-appropriate tools (ESLint, pylint, Checkstyle, Roslyn)
- Measure cyclomatic and cognitive complexity per function and module
- Detect code duplication and suggest extraction opportunities
- Identify dead code, unreachable branches, and unused dependencies

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
