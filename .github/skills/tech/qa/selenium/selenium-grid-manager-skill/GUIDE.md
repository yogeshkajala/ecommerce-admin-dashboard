# Selenium Grid Manager Skill

> **Category:** Tech Skills > QA > Selenium

## Overview

Deploys and manages Selenium Grid for distributed test execution with proper node configuration and Docker integration

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [selenium-grid-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
selenium-grid-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@selenium-grid-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Deploy Selenium Grid 4 with hub and nodes
- Configure Docker-based grid with Compose
- Implement dynamic grid scaling on Kubernetes
- Monitor grid sessions and node health

## Technology Standards Applied

- **Selenium Grid 4**: Grid architecture and configuration
- **Docker Grid**: Container-based grid deployment
- **Grid Scaling**: Dynamic node scaling patterns