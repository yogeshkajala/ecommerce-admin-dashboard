# PHP Composer Manager Skill

> **Category:** Tech Skills > Backend > PHP

## Overview

Manages PHP dependencies with Composer including autoloading, version constraints, private packages, and monorepo support

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [php-composer-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
php-composer-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@php-composer-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure composer.json with proper constraints
- Set up PSR-4 autoloading for project namespaces
- Manage private packages with Satis
- Configure Composer scripts for automation

## Technology Standards Applied

- **Composer**: PHP dependency management best practices
- **PSR-4**: Autoloading standard for PHP classes
- **Semver**: Semantic versioning for PHP packages