# Labeling Compliance Checker Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when checking pharmaceutical labeling compliance including container labeling, carton labeling, serialization marking, country-specific labeling requirements, and artwork management for global pharmaceutical distribution.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [labeling-compliance-checker-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
labeling-compliance-checker-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@labeling-compliance-checker` agent from the Independent Agents catalogue.

## Key Capabilities

- Verify label content against approved regulatory labeling text
- Check serialization data carriers: 2D barcodes, human-readable text quality
- Validate country-specific requirements: language, symbols, controlled substance markings
- Manage artwork lifecycle: creation, proofing, approval, printing, archival

## Industry Standards Applied

- **21 CFR 201**: FDA drug labeling requirements for container and carton labels
- **EU FMD**: EU Falsified Medicines Directive serialization and tamper evidence
- **GS1 General Specifications**: Barcode and data carrier specifications for pharmaceutical labeling