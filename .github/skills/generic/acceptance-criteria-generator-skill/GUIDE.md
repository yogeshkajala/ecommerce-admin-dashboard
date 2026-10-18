# Acceptance Criteria Generator Skill

> **Category:** Domain Skills

## Overview

Use when generating measurable acceptance criteria in Given/When/Then (Gherkin) format for each requirement, including positive, negative, and edge case scenarios.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [acceptance-criteria-generator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
acceptance-criteria-generator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@acceptance-criteria-generator` agent from the Independent Agents catalogue.

## Key Capabilities

- Elicit requirements through stakeholder interviews and document analysis
- Write user stories with measurable acceptance criteria
- Validate requirements for completeness, consistency, and testability
- Prioritize requirements using MoSCoW, WSJF, or value-based scoring

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
