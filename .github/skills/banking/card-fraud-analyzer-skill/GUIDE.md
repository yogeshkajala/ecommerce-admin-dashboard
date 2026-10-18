# Card Fraud Analyzer Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when analyzing card fraud patterns across issuing and acquiring portfolios, building fraud detection rule strategies, measuring fraud prevention effectiveness, and reporting card fraud metrics to payment networks.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [card-fraud-analyzer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
card-fraud-analyzer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@card-fraud-analyzer` agent from the Independent Agents catalogue.

## Key Capabilities

- Analyze fraud patterns by transaction type: CNP, CP, ATM, mobile wallet
- Build rule-based fraud detection strategies targeting emerging fraud vectors
- Measure fraud basis points against industry and network benchmarks
- Calculate false positive rates and customer friction impact

## Industry Standards Applied

- **EMV Chip Specifications**: Chip card authentication for counterfeit fraud prevention
- **PCI DSS v4.0**: Card data security for fraud prevention
- **Visa TC40**: Visa fraud reporting requirements for issuers