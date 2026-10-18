# Internet Banking Security Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when assessing and hardening internet banking platform security including authentication mechanisms, session management, transaction signing, and compliance with FFIEC Authentication Guidance.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [internet-banking-security-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
internet-banking-security-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@internet-banking-security` agent from the Independent Agents catalogue.

## Key Capabilities

- Assess multi-factor authentication implementation per FFIEC guidance
- Test transaction signing mechanisms: hardware tokens, push notification, SMS OTP
- Validate session management: timeout, concurrent session, and re-authentication
- Evaluate adaptive authentication and risk-based step-up controls

## Industry Standards Applied

- **FFIEC Authentication Guidance**: Authentication and access to internet-based financial services
- **OWASP ASVS v4.0**: Application Security Verification Standard for web banking
- **NIST SP 800-63B**: Digital identity authentication assurance levels