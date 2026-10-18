# JMeter Distributed Tester Skill

> **Category:** Tech Skills > QA > JMeter

## Overview

Configures JMeter distributed testing across multiple machines for high-volume load generation and result aggregation

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [jmeter-distributed-tester-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
jmeter-distributed-tester-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@jmeter-distributed-tester` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure JMeter in distributed mode
- Set up remote test engines
- Aggregate results from multiple nodes
- Configure network for distributed execution

## Technology Standards Applied

- **Distributed Testing**: JMeter remote testing configuration
- **Result Aggregation**: Combining results from multiple nodes
- **Network Config**: RMI and network settings for distribution