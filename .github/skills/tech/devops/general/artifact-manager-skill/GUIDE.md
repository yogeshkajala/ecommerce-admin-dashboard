# Artifact Manager Skill

> **Category:** Tech Skills

## Overview

Use when managing build artifacts including packaging, signing, SBOM generation, and registry storage.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [artifact-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
artifact-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@artifact-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Provision and configure cloud infrastructure across AWS, Azure, and GCP
- Validate infrastructure-as-code templates for security and compliance
- Execute capacity planning based on workload patterns and growth projections
- Configure auto-scaling policies with appropriate thresholds and cooldowns

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
