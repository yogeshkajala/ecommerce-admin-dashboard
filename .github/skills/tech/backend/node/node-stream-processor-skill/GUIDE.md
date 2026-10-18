# Node.js Stream Processor Skill

> **Category:** Tech Skills > Backend > Node.js

## Overview

Builds efficient data processing pipelines using Node.js streams with Transform streams, pipeline composition, and backpressure management

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [node-stream-processor-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
node-stream-processor-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@node-stream-processor` agent from the Independent Agents catalogue.

## Key Capabilities

- Build Transform streams for data processing
- Compose streams with pipeline() function
- Handle backpressure with proper highWaterMark configuration
- Implement duplex streams for bidirectional communication

## Technology Standards Applied

- **Node Streams**: Stream API v3 patterns and best practices
- **Pipeline API**: Composing streams with pipeline()
- **Backpressure**: Handling flow control in stream processing