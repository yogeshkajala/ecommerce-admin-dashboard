# Aws Deployer Skill

> **Category:** Tech Skills

## Overview

Deploy to AWS: ECS, EKS, Lambda, S3, CloudFront, RDS, and supporting services.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [aws-deployer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
aws-deployer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@aws-deployer` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure CI/CD pipelines with build, test, scan, and deploy stages
- Execute deployment strategies: rolling, blue-green, canary, and progressive rollout
- Manage environment promotion workflows with approval gates
- Validate deployment health through automated smoke tests and metric checks

## Industry Standards Applied

- **Well-Architected Framework**: Cloud architecture pillars: security, reliability, performance, cost, operations
- **12-Factor App**: Methodology for building cloud-native, scalable services
- **CIS Benchmarks**: Security configuration baselines for cloud platforms
