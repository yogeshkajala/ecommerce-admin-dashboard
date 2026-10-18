# Microservice Observability Specialist Skill

> **Category:** Tech Skills > Others > Microservices

## Overview

Implements distributed observability for microservices with tracing, logging, and metrics correlation across service boundaries

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [microservice-observability-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
microservice-observability-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@microservice-observability-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Implement distributed tracing with OpenTelemetry
- Correlate logs with trace and span IDs
- Configure service-level metrics and SLIs
- Build dependency maps from tracing data

## Technology Standards Applied

- **OpenTelemetry**: Distributed observability standard
- **Distributed Tracing**: Trace propagation across services
- **Log Correlation**: Cross-service log correlation patterns