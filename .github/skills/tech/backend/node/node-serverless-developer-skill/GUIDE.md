# Node.js Serverless Developer Skill

> **Category:** Tech Skills > Backend > Node.js

## Overview

Builds serverless applications with Node.js on AWS Lambda, Azure Functions, or Vercel including cold start optimization and event processing

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [node-serverless-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
node-serverless-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@node-serverless-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Build AWS Lambda handlers with proper event typing
- Create Azure Functions with bindings and triggers
- Optimize cold start with provisioned concurrency
- Implement event-driven architectures with SQS/EventBridge

## Technology Standards Applied

- **AWS Lambda**: Lambda best practices for Node.js
- **Serverless Framework**: Multi-cloud serverless deployment patterns
- **Cold Start**: Cold start optimization techniques