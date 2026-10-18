# Dependency Scanner Skill

> **Category:** Tech Skills

## Overview

Use when scanning dependencies for CVE vulnerabilities, outdated packages, license compliance issues, or generating SBOM (Software Bill of Materials).

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [dependency-scanner-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
dependency-scanner-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@dependency-scanner` agent from the Independent Agents catalogue.

## Key Capabilities

- Execute static analysis using language-appropriate tools (ESLint, pylint, Checkstyle, Roslyn)
- Measure cyclomatic and cognitive complexity per function and module
- Detect code duplication and suggest extraction opportunities
- Identify dead code, unreachable branches, and unused dependencies

## Industry Standards Applied

- **OWASP Top 10**: Critical web/API security risks and mitigation strategies
- **NIST CSF**: Cybersecurity framework: Identify, Protect, Detect, Respond, Recover
- **CIS Benchmarks**: Configuration security baselines for platforms and cloud services
- **MITRE ATT and CK**: Adversarial tactics, techniques, and procedures knowledge base
