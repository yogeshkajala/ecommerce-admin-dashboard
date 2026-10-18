---
description: "Cassandra Data Modeler skill -- Designs Cassandra data models with proper partition keys, clustering columns, and denormalization for distributed query patterns"
---

# Cassandra Data Modeler Skill

**Category:** Tech Skills > Database > Cassandra

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Cassandra Data Modeler operations using Cassandra technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Cassandra within Database development.

## When to Use

- When designing Cassandra tables for specific query patterns
- When choosing partition keys for even data distribution
- When implementing denormalization for query optimization
- When Cassandra-specific technical expertise is required
- When best practices for Cassandra technology stack must be applied
- When production-grade Cassandra implementation guidance is needed

## Capabilities

- Design partition keys for balanced data distribution
- Choose clustering columns for sort order
- Implement denormalization for query-driven design
- Create materialized views for alternative query patterns
- Design time-series data models with bucketing

## Procedure

1. Analyze query access patterns
2. Design conceptual data model
3. Map queries to table designs
4. Choose partition and clustering keys
5. Validate partition sizes
6. Test with representative data volumes

## Output Format

Return structured results:

- **Data Model**
- **Partition Analysis**
- **Query Mapping**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Cassandra Data Modeling** | Query-driven data modeling best practices |
| **Partition Key Design** | Even distribution and size management |
| **Denormalization** | Trading storage for query performance |

## Anti-Hallucination Rules

- Do not design tables without knowing the query patterns
- Verify data modeling features in target Cassandra version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Partition sizes are within recommended limits
- All queries are served by designed tables
- Data distribution is balanced across nodes
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Cassandra community best practices

## Integration Points

- **Companion Agent**: `@cassandra-data-modeler` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Cassandra coverage |
<!-- Technology knowledge base entry for Cassandra Data Modeler in Cassandra Database -->