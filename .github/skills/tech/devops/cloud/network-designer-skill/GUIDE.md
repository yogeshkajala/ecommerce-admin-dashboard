# Network Designer Skill

> **Category:** Tech Skills

## Overview

Design cloud networking: VPCs, subnets, load balancers, DNS, CDN configuration.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [network-designer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
network-designer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@network-designer` agent from the Independent Agents catalogue.

## Key Capabilities

- Provision and configure cloud infrastructure across AWS, Azure, and GCP
- Validate infrastructure-as-code templates for security and compliance
- Execute capacity planning based on workload patterns and growth projections
- Configure auto-scaling policies with appropriate thresholds and cooldowns

## Industry Standards Applied

- **SOLID Principles**: Object-oriented design: Single Responsibility, Open/Closed, Liskov, Interface Segregation, Dependency Inversion
- **Domain-Driven Design**: Bounded contexts, aggregates, ubiquitous language
- **Microservice Patterns**: Service decomposition, API gateway, circuit breaker, saga, CQRS
