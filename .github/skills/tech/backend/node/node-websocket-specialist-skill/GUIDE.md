# Node.js WebSocket Specialist Skill

> **Category:** Tech Skills > Backend > Node.js

## Overview

Implements WebSocket communication in Node.js with Socket.io or ws library including room management, scaling, and reconnection handling

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [node-websocket-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
node-websocket-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@node-websocket-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Implement WebSocket servers with ws or Socket.io
- Design room and namespace management
- Configure Redis adapter for horizontal scaling
- Handle reconnection and connection state

## Technology Standards Applied

- **WebSocket Protocol**: RFC 6455 WebSocket protocol specification
- **Socket.io**: Socket.io rooms, namespaces, and scaling
- **ws Library**: Lightweight WebSocket library for Node.js