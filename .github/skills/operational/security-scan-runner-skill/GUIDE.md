# Security Scan Runner Skill

> **Category:** Domain Skills

## Overview

Use when running security scans on deployment artifacts to detect vulnerabilities before deployment execution.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [security-scan-runner-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
security-scan-runner-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@security-scan-runner` agent from the Independent Agents catalogue.

## Key Capabilities

- Evaluate compliance posture against regulatory frameworks (SOC2, GDPR, HIPAA, PCI-DSS)
- Assess control effectiveness through evidence collection and gap analysis
- Detect policy violations and configuration drift from security baselines
- Generate audit findings with severity classification and remediation guidance

## Industry Standards Applied

- **OWASP Top 10**: Critical web/API security risks and mitigation strategies
- **NIST CSF**: Cybersecurity framework: Identify, Protect, Detect, Respond, Recover
- **CIS Benchmarks**: Configuration security baselines for platforms and cloud services
- **MITRE ATT and CK**: Adversarial tactics, techniques, and procedures knowledge base
