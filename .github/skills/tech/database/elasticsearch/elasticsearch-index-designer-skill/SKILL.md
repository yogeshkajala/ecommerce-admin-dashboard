---
description: "Elasticsearch Index Designer skill -- Designs Elasticsearch index structures with proper mappings, settings, and lifecycle management for efficient search and analytics"
---

# Elasticsearch Index Designer Skill

**Category:** Tech Skills > Database > Elasticsearch

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Elasticsearch Index Designer operations using Elasticsearch technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Elasticsearch within Database development.

## When to Use

- When designing Elasticsearch index structures for search workloads
- When configuring index settings for performance
- When implementing index lifecycle management for data retention
- When Elasticsearch-specific technical expertise is required
- When best practices for Elasticsearch technology stack must be applied
- When production-grade Elasticsearch implementation guidance is needed

## Capabilities

- Design index mappings with proper field types
- Configure shards and replicas for performance
- Implement index templates for consistent configuration
- Set up Index Lifecycle Management (ILM) policies
- Design index aliases for zero-downtime reindexing

## Procedure

1. Analyze search and analytics requirements
2. Design index mapping with field types
3. Configure shard count and replica settings
4. Create index templates for standardization
5. Set up ILM for data lifecycle management
6. Test with representative data volumes

## Output Format

Return structured results:

- **Index Mapping**
- **ILM Configuration**
- **Settings Optimization**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Index Design** | Mapping and settings best practices |
| **ILM** | Index lifecycle management policies |
| **Sharding** | Shard sizing and distribution guidelines |

## Anti-Hallucination Rules

- Do not use dynamic mapping in production without explicit templates
- Verify mapping features in target Elasticsearch version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Shard sizes are within recommended range
- ILM policies handle retention properly
- Mappings support all required query types
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Elasticsearch community best practices

## Integration Points

- **Companion Agent**: `@elasticsearch-index-designer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Elasticsearch coverage |