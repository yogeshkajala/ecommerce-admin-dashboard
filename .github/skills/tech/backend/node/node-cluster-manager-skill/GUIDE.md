# Node.js Cluster Manager Skill

> **Category:** Tech Skills > Backend > Node.js

## Overview

Configures Node.js clustering for multi-core utilization with process management, IPC communication, and graceful shutdown handling

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [node-cluster-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
node-cluster-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@node-cluster-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure cluster module for multi-core utilization
- Implement IPC communication between workers
- Handle graceful shutdown with connection draining
- Set up PM2 for production process management

## Technology Standards Applied

- **Cluster Module**: Node.js cluster module patterns
- **PM2**: Production process manager for Node.js
- **Graceful Shutdown**: Connection draining and cleanup patterns