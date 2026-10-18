# Mobile Banking Tester Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when testing mobile banking applications for functionality, security, performance, accessibility, and regulatory compliance including biometric authentication, remote deposit capture, and payment features.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [mobile-banking-tester-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
mobile-banking-tester-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@mobile-banking-tester` agent from the Independent Agents catalogue.

## Key Capabilities

- Execute functional testing across account management, transfers, and payments
- Validate biometric authentication: Face ID, Touch ID, fingerprint, and fallback flows
- Test remote deposit capture with image quality validation and duplicate detection
- Verify push notification delivery for alerts, OTP, and transaction confirmations

## Industry Standards Applied

- **OWASP MASVS**: Mobile Application Security Verification Standard
- **WCAG 2.1 AA**: Accessibility guidelines for mobile application interfaces
- **FFIEC Mobile Banking Guidance**: Regulatory guidance on mobile banking risk management