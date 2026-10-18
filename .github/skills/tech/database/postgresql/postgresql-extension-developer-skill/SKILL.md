---
description: "PostgreSQL Extension Developer skill -- Creates and manages PostgreSQL extensions including PostGIS, pgvector, and custom extensions for specialized database functionality"
---

# PostgreSQL Extension Developer Skill

**Category:** Tech Skills > Database > PostgreSQL

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for PostgreSQL Extension Developer operations using PostgreSQL technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for PostgreSQL within Database development.

## When to Use

- When installing and configuring PostgreSQL extensions
- When implementing geospatial queries with PostGIS
- When adding vector similarity search with pgvector
- When PostgreSQL-specific technical expertise is required
- When best practices for PostgreSQL technology stack must be applied
- When production-grade PostgreSQL implementation guidance is needed

## Capabilities

- Install and configure PostGIS for geospatial data
- Set up pgvector for AI embedding similarity search
- Configure pg_stat_statements for query monitoring
- Build custom extensions with C or PL/pgSQL
- Manage extension versions and upgrades

## Procedure

1. Identify extension requirements for workload
2. Install extensions with proper configuration
3. Configure extension-specific settings
4. Test extension functionality and performance
5. Plan extension upgrade strategy
6. Monitor extension impact on performance

## Output Format

Return structured results:

- **Extension Configuration**
- **Performance Impact**
- **Upgrade Plan**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **PostgreSQL Extensions** | Extension installation and management |
| **PostGIS** | Geospatial data types and functions |
| **pgvector** | Vector similarity search extension |

## Anti-Hallucination Rules

- Do not assume extension availability on all PostgreSQL providers
- Verify extension version compatibility with PostgreSQL version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Extensions do not degrade baseline performance
- Configuration is optimized for workload
- Upgrade path is documented and tested
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow PostgreSQL community best practices

## Integration Points

- **Companion Agent**: `@postgresql-extension-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full PostgreSQL coverage |