# JMeter Test Plan Builder Skill

> **Category:** Tech Skills > QA > JMeter

## Overview

Creates JMeter test plans for load testing with proper thread groups, samplers, and assertions for performance validation

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [jmeter-test-plan-builder-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
jmeter-test-plan-builder-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@jmeter-test-plan-builder` agent from the Independent Agents catalogue.

## Key Capabilities

- Design thread groups with proper ramp-up
- Configure HTTP samplers with parameters
- Implement assertions for response validation
- Use CSV data sets for parameterization

## Technology Standards Applied

- **JMeter Test Plan**: Test plan structure and elements
- **Thread Groups**: User simulation and ramp-up patterns
- **Assertions**: Response validation in load tests