# AWS S3 Specialist Skill

> **Category:** Tech Skills > DevOps > AWS

## Overview

Configures Amazon S3 for object storage with proper bucket policies, lifecycle rules, and security for production workloads

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [aws-s3-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
aws-s3-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@aws-s3-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure bucket policies and access points
- Implement lifecycle rules for storage class transitions
- Set up cross-region replication for durability
- Configure event notifications for S3 triggers

## Technology Standards Applied

- **S3 Security**: Bucket policy and access control best practices
- **Lifecycle Rules**: Storage class transition and expiration
- **Encryption**: Server-side encryption configuration