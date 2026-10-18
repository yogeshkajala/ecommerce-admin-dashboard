# Nginx Reverse Proxy Specialist Skill

> **Category:** Tech Skills > Others > Nginx

## Overview

Configures Nginx as a reverse proxy with upstream balancing, header management, and WebSocket support for application delivery

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [nginx-reverse-proxy-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
nginx-reverse-proxy-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@nginx-reverse-proxy-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure reverse proxy with proxy_pass
- Implement upstream load balancing
- Handle WebSocket upgrade headers
- Configure proxy headers for client info

## Technology Standards Applied

- **Reverse Proxy**: Nginx proxy configuration patterns
- **Load Balancing**: Upstream balancing algorithms
- **WebSocket**: WebSocket proxy configuration