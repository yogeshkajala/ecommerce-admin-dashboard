# Pharma Supply Chain Tracker Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when tracking pharmaceutical supply chain operations including DSCSA serialization compliance, supply chain visibility, counterfeit detection, and end-to-end traceability for drug product distribution.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [pharma-supply-chain-tracker-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
pharma-supply-chain-tracker-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@pharma-supply-chain-tracker` agent from the Independent Agents catalogue.

## Key Capabilities

- Track serialized product through supply chain: manufacturer to dispenser
- Verify product authenticity using serialization data at each supply chain node
- Manage DSCSA transaction information (TI), transaction history (TH), and transaction statement (TS)
- Detect suspect and illegitimate products through verification processes

## Industry Standards Applied

- **DSCSA (Drug Supply Chain Security Act)**: US pharmaceutical serialization and traceability requirements
- **EU FMD (Falsified Medicines Directive)**: EU pharmaceutical serialization and anti-counterfeiting
- **GS1 Standards**: Global serialization and data carrier standards for pharma