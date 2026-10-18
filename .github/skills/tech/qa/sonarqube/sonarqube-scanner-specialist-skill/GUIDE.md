# SonarQube Scanner Specialist Skill

> **Category:** Tech Skills > QA > SonarQube

## Overview

Configures SonarQube scanners for different build tools and languages including Maven, Gradle, and CLI scanner with proper properties

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [sonarqube-scanner-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
sonarqube-scanner-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@sonarqube-scanner-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure sonar-scanner CLI for any project
- Integrate with Maven, Gradle, and npm builds
- Set analysis properties for proper configuration
- Handle multi-module project analysis

## Technology Standards Applied

- **SonarScanner**: Scanner configuration and execution
- **Analysis Properties**: Key analysis parameters
- **Multi-Module**: Multi-module project configuration