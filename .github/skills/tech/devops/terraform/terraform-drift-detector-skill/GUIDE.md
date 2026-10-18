# Terraform Drift Detector Skill

> **Category:** Tech Skills > DevOps > Terraform

## Overview

Detects and remediates infrastructure drift between Terraform state and actual cloud resources for configuration consistency

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [terraform-drift-detector-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
terraform-drift-detector-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@terraform-drift-detector` agent from the Independent Agents catalogue.

## Key Capabilities

- Detect drift with terraform plan in CI/CD
- Implement scheduled drift detection workflows
- Analyze drift causes and impact
- Automate drift remediation with apply

## Technology Standards Applied

- **Drift Detection**: Infrastructure drift detection methodology
- **Continuous Compliance**: Scheduled configuration verification
- **Remediation**: Drift resolution strategies