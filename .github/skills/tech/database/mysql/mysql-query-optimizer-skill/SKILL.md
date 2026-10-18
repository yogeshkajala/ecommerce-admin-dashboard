---
description: "MySQL Query Optimizer skill -- Analyzes and optimizes MySQL queries using EXPLAIN, index optimization, and query rewriting for InnoDB storage engine performance"
---

# MySQL Query Optimizer Skill

**Category:** Tech Skills > Database > MySQL

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for MySQL Query Optimizer operations using MySQL technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for MySQL within Database development.

## When to Use

- When optimizing slow MySQL queries with EXPLAIN
- When designing index strategies for InnoDB tables
- When tuning MySQL query cache and buffer pool
- When MySQL-specific technical expertise is required
- When best practices for MySQL technology stack must be applied
- When production-grade MySQL implementation guidance is needed

## Capabilities

- Analyze queries with EXPLAIN FORMAT=JSON
- Design composite indexes for covering queries
- Optimize InnoDB buffer pool configuration
- Rewrite queries to avoid full table scans
- Configure optimizer hints for query plan control

## Procedure

1. Enable slow query log and identify bottlenecks
2. Analyze execution plans with EXPLAIN
3. Design missing indexes based on query patterns
4. Tune InnoDB buffer pool and log settings
5. Test query improvements with benchmarks
6. Monitor improvements with Performance Schema

## Output Format

Return structured results:

- **Query Analysis**
- **Index Strategy**
- **Performance Metrics**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **MySQL EXPLAIN** | Query execution plan analysis |
| **InnoDB Optimization** | Storage engine tuning guidelines |
| **Performance Schema** | Query monitoring and diagnostics |

## Anti-Hallucination Rules

- Do not assume MyISAM optimizations apply to InnoDB
- Verify optimizer features in target MySQL version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Optimized queries use indexes effectively
- Buffer pool hit ratio exceeds 99%
- No full table scans on large tables for filtered queries
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow MySQL community best practices

## Integration Points

- **Companion Agent**: `@mysql-query-optimizer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full MySQL coverage |
<!-- Technology knowledge base entry for MySQL Query Optimizer in MySQL Database -->
<!-- Technology knowledge base entry for MySQL Query Optimizer in MySQL Database -->