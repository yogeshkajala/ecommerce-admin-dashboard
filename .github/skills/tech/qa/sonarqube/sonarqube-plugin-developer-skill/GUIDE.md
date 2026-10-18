# SonarQube Plugin Developer Skill

> **Category:** Tech Skills > QA > SonarQube

## Overview

Creates SonarQube plugins for custom analyzers, sensors, and decorators to extend code quality analysis capabilities

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [sonarqube-plugin-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
sonarqube-plugin-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@sonarqube-plugin-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Build plugins with SonarQube Plugin API
- Implement custom sensors for code analysis
- Create custom rules with check visitors
- Add custom metrics and measures

## Technology Standards Applied

- **Plugin API**: SonarQube plugin development guide
- **Custom Rules**: Rule implementation patterns
- **Sensors**: Code analysis sensor design