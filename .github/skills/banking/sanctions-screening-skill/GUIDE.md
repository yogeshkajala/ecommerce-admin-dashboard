# Sanctions Screening Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when screening transactions, customers, and counterparties against sanctions lists (OFAC, EU, UN, HMT), managing screening rule calibration, and handling sanctions alert investigation workflows.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [sanctions-screening-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
sanctions-screening-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@sanctions-screening` agent from the Independent Agents catalogue.

## Key Capabilities

- Screen names against OFAC SDN, Consolidated, Sectoral, and Non-SDN lists
- Match against EU consolidated financial sanctions list and UN Security Council lists
- Screen payment messages (SWIFT MT/MX) against all applicable sanctions programs
- Apply fuzzy matching algorithms with configurable thresholds for name variations

## Industry Standards Applied

- **OFAC Regulations**: US sanctions compliance, SDN list screening, and blocking requirements
- **EU Restrictive Measures**: European Union financial sanctions implementation
- **UN Security Council Resolutions**: UN targeted financial sanctions requirements