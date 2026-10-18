# Terraform Plan Reviewer Skill

> **Category:** Tech Skills > DevOps > Terraform

## Overview

Reviews and validates Terraform plans with policy enforcement, cost estimation, and change impact analysis before apply

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [terraform-plan-reviewer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
terraform-plan-reviewer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@terraform-plan-reviewer` agent from the Independent Agents catalogue.

## Key Capabilities

- Analyze terraform plan output for change impact
- Implement OPA policies for plan validation
- Estimate costs with Infracost integration
- Detect security issues with tfsec or Checkov

## Technology Standards Applied

- **Plan Analysis**: Terraform plan review methodology
- **OPA Policies**: Policy-as-code for infrastructure
- **Infracost**: Cost estimation for infrastructure changes