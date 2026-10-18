---
description: "PostgreSQL Query Optimizer skill -- Analyzes and optimizes PostgreSQL queries using EXPLAIN plans, index strategies, and query rewriting for maximum performance"
---

# PostgreSQL Query Optimizer Skill

**Category:** Tech Skills > Database > PostgreSQL

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for PostgreSQL Query Optimizer operations using PostgreSQL technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for PostgreSQL within Database development.

## When to Use

- When optimizing slow PostgreSQL queries with EXPLAIN ANALYZE
- When designing index strategies for complex query patterns
- When rewriting queries for better execution plans
- When PostgreSQL-specific technical expertise is required
- When best practices for PostgreSQL technology stack must be applied
- When production-grade PostgreSQL implementation guidance is needed

## Capabilities

- Analyze EXPLAIN ANALYZE output for bottlenecks
- Design B-tree, GIN, GiST, and BRIN index strategies
- Rewrite queries with CTEs, window functions, and lateral joins
- Optimize join order and statistics accuracy
- Configure autovacuum and query planner parameters

## Procedure

1. Capture slow queries with pg_stat_statements
2. Analyze execution plans with EXPLAIN (ANALYZE, BUFFERS)
3. Identify missing or unused indexes
4. Rewrite inefficient query patterns
5. Update table statistics with ANALYZE
6. Benchmark improvements with pgbench

## Output Format

Return structured results:

- **Query Analysis**
- **Index Recommendations**
- **Performance Benchmarks**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **PostgreSQL Performance** | Official query optimization documentation |
| **Index Types** | Choosing appropriate index types for workloads |
| **EXPLAIN** | Execution plan analysis methodology |

## Anti-Hallucination Rules

- Do not assume index creation always improves performance
- Verify PostgreSQL version features for query syntax
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Query plans show index usage where expected
- No sequential scans on large tables for filtered queries
- Statistics are up to date for accurate planning
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow PostgreSQL community best practices

## Integration Points

- **Companion Agent**: `@postgresql-query-optimizer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full PostgreSQL coverage |