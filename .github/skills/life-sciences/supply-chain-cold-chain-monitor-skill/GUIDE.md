# Supply Chain Cold Chain Monitor Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when monitoring pharmaceutical cold chain integrity including temperature monitoring, excursion detection, cold chain qualification, and GDP compliance for temperature-sensitive pharmaceutical distribution.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [supply-chain-cold-chain-monitor-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
supply-chain-cold-chain-monitor-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@supply-chain-cold-chain-monitor` agent from the Independent Agents catalogue.

## Key Capabilities

- Monitor real-time temperature data from IoT sensors across supply chain
- Detect temperature excursions and assess against product stability specifications
- Calculate mean kinetic temperature (MKT) for excursion impact assessment
- Qualify shipping lanes with temperature mapping and seasonal validation

## Industry Standards Applied

- **EU GDP Guidelines (2013/C 343/01)**: Good Distribution Practice for temperature-sensitive pharmaceuticals
- **WHO TRS 961 Annex 9**: WHO model guidance for storage and transport of pharmaceuticals
- **USP <1079>**: Good storage and distribution practices for drug products