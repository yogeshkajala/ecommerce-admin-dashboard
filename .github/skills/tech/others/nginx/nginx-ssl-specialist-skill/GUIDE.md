# Nginx SSL/TLS Specialist Skill

> **Category:** Tech Skills > Others > Nginx

## Overview

Configures Nginx SSL/TLS with proper certificate management, cipher suites, and HSTS for secure HTTPS communication

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [nginx-ssl-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
nginx-ssl-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@nginx-ssl-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure SSL/TLS with modern cipher suites
- Implement HSTS for strict transport security
- Set up OCSP stapling for certificate validation
- Automate certificate renewal with certbot

## Technology Standards Applied

- **SSL Configuration**: TLS configuration best practices
- **Mozilla SSL Config**: Modern, intermediate, old compatibility
- **HSTS**: HTTP Strict Transport Security