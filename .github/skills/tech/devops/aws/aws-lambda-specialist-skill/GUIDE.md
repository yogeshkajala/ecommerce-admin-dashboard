# AWS Lambda Specialist Skill

> **Category:** Tech Skills > DevOps > AWS

## Overview

Builds serverless applications with AWS Lambda including function design, event sources, and performance optimization

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [aws-lambda-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
aws-lambda-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@aws-lambda-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Design Lambda functions with proper memory and timeout
- Configure event source mappings for SQS, S3, DynamoDB
- Optimize cold start with provisioned concurrency
- Implement Lambda Layers for shared dependencies

## Technology Standards Applied

- **Lambda Best Practices**: Function design and performance guidelines
- **SAM**: Serverless Application Model for deployment
- **Lambda Powertools**: Operational tooling for Lambda