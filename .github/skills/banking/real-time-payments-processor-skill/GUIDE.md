# Real Time Payments Processor Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when implementing and managing real-time payment processing including FedNow, RTP network, ISO 20022 message handling, instant payment fraud controls, and 24/7/365 availability requirements.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [real-time-payments-processor-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
real-time-payments-processor-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@real-time-payments-processor` agent from the Independent Agents catalogue.

## Key Capabilities

- Process real-time payment messages per FedNow and RTP specifications
- Validate ISO 20022 pacs.008 credit transfer messages end-to-end
- Implement real-time fraud scoring with sub-second response requirements
- Manage receive-side and send-side payment processing flows

## Industry Standards Applied

- **FedNow Service Operating Rules**: Federal Reserve instant payment service requirements
- **RTP Operating Rules**: The Clearing House Real-Time Payments network rules
- **ISO 20022**: Universal financial messaging standard for instant payments