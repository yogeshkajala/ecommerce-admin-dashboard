# AWS ECS Specialist Skill

> **Category:** Tech Skills > DevOps > AWS

## Overview

Deploys containerized applications with Amazon ECS including Fargate, task definitions, and service auto-scaling

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [aws-ecs-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
aws-ecs-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@aws-ecs-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Create ECS clusters with Fargate or EC2 launch types
- Design task definitions with proper resource allocation
- Configure services with load balancer integration
- Implement auto-scaling based on CPU or custom metrics

## Technology Standards Applied

- **ECS Best Practices**: Task and service configuration guidelines
- **Fargate**: Serverless container deployment
- **Service Discovery**: Cloud Map integration for ECS