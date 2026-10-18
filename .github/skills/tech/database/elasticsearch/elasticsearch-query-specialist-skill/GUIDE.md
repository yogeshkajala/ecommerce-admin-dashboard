# Elasticsearch Query Specialist Skill

> **Category:** Tech Skills > Database > Elasticsearch

## Overview

Builds complex Elasticsearch queries using Query DSL, aggregations, and scoring for relevant search results and analytics

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [elasticsearch-query-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
elasticsearch-query-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@elasticsearch-query-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Build complex queries with bool, nested, and function_score
- Implement aggregations for faceted search and analytics
- Tune relevance with custom scoring functions
- Design suggesters for autocomplete and spell correction

## Technology Standards Applied

- **Query DSL**: Elasticsearch query language patterns
- **Aggregations**: Metric, bucket, and pipeline aggregations
- **Relevance**: BM25 scoring and custom relevance tuning