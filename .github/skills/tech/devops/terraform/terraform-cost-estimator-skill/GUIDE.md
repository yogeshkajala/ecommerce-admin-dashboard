# Terraform Cost Estimator Skill

> **Category:** Tech Skills > DevOps > Terraform

## Overview

Estimates infrastructure costs from Terraform plans using Infracost and implements cost policies for budget management

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [terraform-cost-estimator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
terraform-cost-estimator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@terraform-cost-estimator` agent from the Independent Agents catalogue.

## Key Capabilities

- Estimate costs with Infracost for Terraform plans
- Implement cost policies with thresholds
- Generate cost reports for pull requests
- Compare costs between environments

## Technology Standards Applied

- **Infracost**: Cost estimation tool and API
- **FinOps**: Cloud financial management practices
- **Cost Policies**: Budget enforcement with policy-as-code