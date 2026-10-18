---
description: "Elasticsearch Query Specialist skill -- Builds complex Elasticsearch queries using Query DSL, aggregations, and scoring for relevant search results and analytics"
---

# Elasticsearch Query Specialist Skill

**Category:** Tech Skills > Database > Elasticsearch

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Elasticsearch Query Specialist operations using Elasticsearch technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Elasticsearch within Database development.

## When to Use

- When building search queries with Elasticsearch Query DSL
- When implementing aggregations for analytics dashboards
- When tuning relevance scoring for search results
- When Elasticsearch-specific technical expertise is required
- When best practices for Elasticsearch technology stack must be applied
- When production-grade Elasticsearch implementation guidance is needed

## Capabilities

- Build complex queries with bool, nested, and function_score
- Implement aggregations for faceted search and analytics
- Tune relevance with custom scoring functions
- Design suggesters for autocomplete and spell correction
- Optimize query performance with filters and caching

## Procedure

1. Analyze search requirements and relevance criteria
2. Design query structure with proper clause types
3. Implement aggregations for facets and analytics
4. Tune scoring with boosting and function_score
5. Test relevance with representative queries
6. Optimize with profile API for performance

## Output Format

Return structured results:

- **Query Designs**
- **Aggregation Pipelines**
- **Relevance Tests**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Query DSL** | Elasticsearch query language patterns |
| **Aggregations** | Metric, bucket, and pipeline aggregations |
| **Relevance** | BM25 scoring and custom relevance tuning |

## Anti-Hallucination Rules

- Do not use queries where filters suffice - filters are cacheable
- Verify query features in target Elasticsearch version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Queries return relevant results within SLA
- Aggregations provide accurate analytics
- Query performance meets latency targets
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Elasticsearch community best practices

## Integration Points

- **Companion Agent**: `@elasticsearch-query-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Elasticsearch coverage |