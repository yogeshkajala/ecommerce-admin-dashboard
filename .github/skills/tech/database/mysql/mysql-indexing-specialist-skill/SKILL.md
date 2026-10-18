---
description: "MySQL Indexing Specialist skill -- Designs optimal MySQL indexing strategies including composite indexes, full-text indexes, and spatial indexes for diverse query workloads"
---

# MySQL Indexing Specialist Skill

**Category:** Tech Skills > Database > MySQL

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for MySQL Indexing Specialist operations using MySQL technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for MySQL within Database development.

## When to Use

- When designing index strategies for MySQL/InnoDB tables
- When implementing full-text search with MySQL indexes
- When analyzing and removing redundant indexes
- When MySQL-specific technical expertise is required
- When best practices for MySQL technology stack must be applied
- When production-grade MySQL implementation guidance is needed

## Capabilities

- Design composite indexes with proper column ordering
- Create full-text indexes for text search
- Implement spatial indexes for geospatial queries
- Analyze index usage with sys schema views
- Identify and remove redundant or unused indexes

## Procedure

1. Analyze query patterns and table structures
2. Design indexes based on query selectivity
3. Create composite indexes with proper ordering
4. Monitor index usage with performance schema
5. Remove unused and duplicate indexes
6. Validate index effectiveness with EXPLAIN

## Output Format

Return structured results:

- **Index Strategy**
- **Usage Analysis**
- **Optimization Report**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **InnoDB Indexes** | Clustered and secondary index design |
| **Index Design** | Composite index column ordering guidelines |
| **sys Schema** | Index usage monitoring views |

## Anti-Hallucination Rules

- Do not create too many indexes on write-heavy tables
- Verify index type availability in target MySQL version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- All frequently-queried columns are properly indexed
- No redundant indexes waste write performance
- Index usage is monitored regularly
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow MySQL community best practices

## Integration Points

- **Companion Agent**: `@mysql-indexing-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full MySQL coverage |
<!-- Technology knowledge base entry for MySQL Indexing Specialist in MySQL Database -->