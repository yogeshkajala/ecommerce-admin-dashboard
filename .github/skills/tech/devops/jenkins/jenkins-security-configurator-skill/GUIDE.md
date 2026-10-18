# Jenkins Security Configurator Skill

> **Category:** Tech Skills > DevOps > Jenkins

## Overview

Configures Jenkins security including authentication, authorization, credentials management, and agent security for production deployments

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [jenkins-security-configurator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
jenkins-security-configurator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@jenkins-security-configurator` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure LDAP and OIDC authentication
- Implement matrix-based security authorization
- Manage credentials with proper scoping
- Secure agent communication with JNLP or SSH

## Technology Standards Applied

- **Jenkins Security**: Security configuration best practices
- **Credentials**: Credential management and scoping
- **Agent Security**: Secure agent communication patterns