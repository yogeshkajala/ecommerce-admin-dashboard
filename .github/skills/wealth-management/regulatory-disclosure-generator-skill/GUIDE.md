# Regulatory Disclosure Generator Skill

> **Category:** Domain Skills > Industry > Wealth Management

## Overview

Use when generating regulatory disclosures for wealth management including Form ADV, Form CRS, proxy voting reports, client privacy notices, and regulatory filing packages for SEC and state registrations.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [regulatory-disclosure-generator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
regulatory-disclosure-generator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@regulatory-disclosure-generator` agent from the Independent Agents catalogue.

## Key Capabilities

- Generate Form ADV Part 1A with firm, personnel, and AUM data
- Draft Form ADV Part 2A brochure with advisory business, fees, and risk disclosures
- Create Form CRS summary document for retail investor relationships
- Compile proxy voting report per SEC Rule 206(4)-6

## Industry Standards Applied

- **SEC Form ADV**: Investment advisor registration and disclosure requirements
- **SEC Form CRS**: Client Relationship Summary for retail investors
- **SEC Rule 206(4)-6**: Proxy voting policies and disclosure for investment advisors