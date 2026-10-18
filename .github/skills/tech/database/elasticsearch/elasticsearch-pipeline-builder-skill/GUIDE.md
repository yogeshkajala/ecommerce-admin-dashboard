# Elasticsearch Pipeline Builder Skill

> **Category:** Tech Skills > Database > Elasticsearch

## Overview

Creates Elasticsearch ingest pipelines for data transformation, enrichment, and normalization during document indexing

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [elasticsearch-pipeline-builder-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
elasticsearch-pipeline-builder-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@elasticsearch-pipeline-builder` agent from the Independent Agents catalogue.

## Key Capabilities

- Build ingest pipelines with processor chains
- Implement data enrichment with enrich processor
- Transform data with script, convert, and grok processors
- Handle pipeline failures with on_failure handlers

## Technology Standards Applied

- **Ingest Pipelines**: Pipeline processor patterns and configuration
- **Enrich Processor**: Document enrichment during indexing
- **Grok Processor**: Pattern matching for log parsing