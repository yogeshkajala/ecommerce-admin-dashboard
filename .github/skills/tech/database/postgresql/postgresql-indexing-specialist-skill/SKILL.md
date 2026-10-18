---
description: "PostgreSQL Indexing Specialist skill -- Designs optimal indexing strategies for PostgreSQL including partial indexes, covering indexes, and expression indexes for complex workloads"
---

# PostgreSQL Indexing Specialist Skill

**Category:** Tech Skills > Database > PostgreSQL

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for PostgreSQL Indexing Specialist operations using PostgreSQL technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for PostgreSQL within Database development.

## When to Use

- When designing index strategies for complex query workloads
- When implementing partial and covering indexes for performance
- When analyzing index usage and removing unused indexes
- When PostgreSQL-specific technical expertise is required
- When best practices for PostgreSQL technology stack must be applied
- When production-grade PostgreSQL implementation guidance is needed

## Capabilities

- Design multi-column indexes with proper column order
- Create partial indexes for filtered queries
- Implement covering indexes with INCLUDE columns
- Build expression indexes for computed values
- Monitor index usage and bloat with pg_stat_user_indexes

## Procedure

1. Analyze query patterns with pg_stat_statements
2. Identify indexing opportunities from slow queries
3. Design indexes with proper column ordering
4. Create partial indexes for common filter conditions
5. Monitor index usage and identify unused indexes
6. Schedule index maintenance with REINDEX

## Output Format

Return structured results:

- **Index Strategy**
- **Usage Analysis**
- **Maintenance Plan**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **PostgreSQL Indexes** | Index type selection and design guidelines |
| **Covering Indexes** | Index-only scans with INCLUDE columns |
| **Partial Indexes** | Conditional indexing for filtered workloads |

## Anti-Hallucination Rules

- Do not create indexes without analyzing query patterns
- Verify index features in target PostgreSQL version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Indexes are used by target queries
- No duplicate or redundant indexes exist
- Index bloat is monitored and managed
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow PostgreSQL community best practices

## Integration Points

- **Companion Agent**: `@postgresql-indexing-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full PostgreSQL coverage |