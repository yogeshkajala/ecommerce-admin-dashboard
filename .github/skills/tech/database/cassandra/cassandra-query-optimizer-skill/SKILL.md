---
description: "Cassandra Query Optimizer skill -- Optimizes Cassandra queries with CQL best practices, secondary indexes, and materialized views for efficient distributed queries"
---

# Cassandra Query Optimizer Skill

**Category:** Tech Skills > Database > Cassandra

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Cassandra Query Optimizer operations using Cassandra technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Cassandra within Database development.

## When to Use

- When optimizing CQL queries for Cassandra performance
- When evaluating secondary indexes vs materialized views
- When troubleshooting slow Cassandra queries with tracing
- When Cassandra-specific technical expertise is required
- When best practices for Cassandra technology stack must be applied
- When production-grade Cassandra implementation guidance is needed

## Capabilities

- Optimize CQL queries for partition-based access
- Evaluate and create secondary indexes where appropriate
- Design materialized views for alternative query paths
- Use tracing to diagnose query performance
- Implement SAI indexes for flexible querying

## Procedure

1. Analyze query patterns and performance
2. Enable tracing on slow queries
3. Evaluate index vs materialized view options
4. Implement chosen optimization strategy
5. Test query performance improvements
6. Monitor query latencies with metrics

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
| **CQL Best Practices** | Query patterns that work well with Cassandra |
| **SAI Indexes** | Storage Attached Indexes for flexible queries |
| **Query Tracing** | Distributed query analysis with tracing |

## Anti-Hallucination Rules

- Do not use ALLOW FILTERING in production queries
- Verify SAI availability in target Cassandra version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Queries access a single partition where possible
- Secondary indexes are on low-cardinality columns
- Materialized views do not cause excessive write amplification
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Cassandra community best practices

## Integration Points

- **Companion Agent**: `@cassandra-query-optimizer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Cassandra coverage |