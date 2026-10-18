# Customer Onboarding Orchestrator Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when orchestrating end-to-end banking customer onboarding workflows including digital account opening, identity verification, KYC/CDD, product bundling, and regulatory disclosure delivery.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [customer-onboarding-orchestrator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
customer-onboarding-orchestrator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@customer-onboarding-orchestrator` agent from the Independent Agents catalogue.

## Key Capabilities

- Orchestrate multi-step digital account opening with form prefill and save/resume
- Manage identity verification through document capture, liveness check, and bureau verification
- Integrate KYC/CDD screening including sanctions, PEP, and adverse media checks
- Deliver required regulatory disclosures: privacy notice, account agreement, fee schedule

## Industry Standards Applied

- **BSA/AML CIP**: Customer Identification Program requirements for account opening
- **ESIGN Act**: Electronic signature and consent requirements for digital onboarding
- **Reg DD (TISA)**: Account disclosure requirements at opening