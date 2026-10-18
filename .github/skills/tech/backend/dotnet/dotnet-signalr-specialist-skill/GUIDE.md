# .NET SignalR Specialist Skill

> **Category:** Tech Skills > Backend > .NET

## Overview

Implements real-time communication with SignalR for web applications including hub design, scaling, and client integration patterns

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [dotnet-signalr-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
dotnet-signalr-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@dotnet-signalr-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Design SignalR hubs with proper method contracts
- Implement strongly-typed hub interfaces
- Configure Redis backplane for horizontal scaling
- Build reconnection and error handling on clients

## Technology Standards Applied

- **SignalR Documentation**: Official SignalR hub and client patterns
- **Scaling SignalR**: Backplane and Azure SignalR Service patterns
- **WebSocket Protocol**: Transport protocol and fallback strategies