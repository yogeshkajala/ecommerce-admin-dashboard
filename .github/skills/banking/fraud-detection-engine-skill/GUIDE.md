# Fraud Detection Engine Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when detecting fraudulent transactions across payment channels (card, ACH, wire, P2P), analyzing fraud patterns using behavioral analytics, and managing fraud case workflows from detection through resolution.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [fraud-detection-engine-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
fraud-detection-engine-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@fraud-detection-engine` agent from the Independent Agents catalogue.

## Key Capabilities

- Score transactions in real-time using ML-based fraud models and rule engines
- Detect card-not-present fraud using device fingerprinting and behavioral biometrics
- Identify account takeover patterns through login anomaly and session analysis
- Analyze ACH fraud including unauthorized debits and business email compromise

## Industry Standards Applied

- **PCI DSS**: Payment card data security standards for fraud prevention
- **EMV 3DS**: 3-D Secure protocol for card-not-present authentication
- **Regulation E**: Electronic fund transfer error resolution and liability rules