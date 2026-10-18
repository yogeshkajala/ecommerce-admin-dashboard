# MongoDB Sharding Specialist Skill

> **Category:** Tech Skills > Database > MongoDB

## Overview

Implements MongoDB sharding for horizontal scaling including shard key selection, chunk management, and balanced data distribution

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [mongodb-sharding-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
mongodb-sharding-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@mongodb-sharding-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Select optimal shard keys based on query patterns
- Configure sharded clusters with config servers
- Manage chunk splitting and balancer settings
- Implement zone-based sharding for data locality

## Technology Standards Applied

- **Shard Key Selection**: Choosing shard keys for balanced distribution
- **Sharding Architecture**: Config servers, mongos, and shard components
- **Zone Sharding**: Geographic data placement with zones