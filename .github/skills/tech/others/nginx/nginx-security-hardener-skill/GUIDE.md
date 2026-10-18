# Nginx Security Hardener Skill

> **Category:** Tech Skills > Others > Nginx

## Overview

Hardens Nginx security with security headers, access control, rate limiting, and WAF-like protections for production deployments

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [nginx-security-hardener-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
nginx-security-hardener-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@nginx-security-hardener` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure security headers: CSP, X-Frame-Options, etc
- Implement rate limiting with limit_req
- Set up IP-based access control
- Configure request size and timeout limits

## Technology Standards Applied

- **Security Headers**: HTTP security header configuration
- **Rate Limiting**: Request rate control with limit_req
- **Access Control**: IP-based and authentication access control