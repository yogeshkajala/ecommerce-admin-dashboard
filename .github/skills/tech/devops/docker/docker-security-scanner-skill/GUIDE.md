# Docker Security Scanner Skill

> **Category:** Tech Skills > DevOps > Docker

## Overview

Implements container security scanning with Trivy, Snyk, and Docker Scout for vulnerability detection and compliance enforcement

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [docker-security-scanner-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
docker-security-scanner-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@docker-security-scanner` agent from the Independent Agents catalogue.

## Key Capabilities

- Scan images with Trivy for CVE detection
- Implement Snyk container scanning in CI/CD
- Use Docker Scout for supply chain analysis
- Enforce CIS Docker Benchmark compliance

## Technology Standards Applied

- **CIS Docker Benchmark**: Container security hardening guidelines
- **Trivy**: Comprehensive vulnerability scanner
- **Supply Chain Security**: SBOM generation and analysis