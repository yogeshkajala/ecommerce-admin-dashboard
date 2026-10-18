---
description: "SQL Server Indexing Specialist skill -- Designs SQL Server indexing strategies including columnstore indexes, filtered indexes, and index maintenance for optimal performance"
---

# SQL Server Indexing Specialist Skill

**Category:** Tech Skills > Database > SQL Server

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for SQL Server Indexing Specialist operations using SQL Server technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for SQL Server within Database development.

## When to Use

- When designing index strategies for SQL Server databases
- When implementing columnstore indexes for analytics
- When managing index fragmentation and maintenance
- When SQL Server-specific technical expertise is required
- When best practices for SQL Server technology stack must be applied
- When production-grade SQL Server implementation guidance is needed

## Capabilities

- Design clustered and nonclustered indexes with included columns
- Create columnstore indexes for analytical queries
- Implement filtered indexes for subset queries
- Manage index fragmentation with reorganize and rebuild
- Use missing index DMVs for recommendations

## Procedure

1. Analyze query patterns with DMVs and execution plans
2. Design indexes based on query selectivity
3. Create columnstore indexes for analytical workloads
4. Implement index maintenance schedule
5. Monitor index usage and fragmentation
6. Remove unused indexes to improve write performance

## Output Format

Return structured results:

- **Index Strategy**
- **Maintenance Schedule**
- **Performance Metrics**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **SQL Server Indexes** | Index design and selection guidelines |
| **Columnstore** | Columnstore index design for analytics |
| **Index Maintenance** | Fragmentation management best practices |

## Anti-Hallucination Rules

- Do not rebuild indexes unnecessarily - check fragmentation first
- Verify index features in target SQL Server version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Indexes serve intended queries efficiently
- Columnstore indexes improve analytics performance
- Maintenance runs within maintenance windows
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow SQL Server community best practices

## Integration Points

- **Companion Agent**: `@sqlserver-indexing-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full SQL Server coverage |