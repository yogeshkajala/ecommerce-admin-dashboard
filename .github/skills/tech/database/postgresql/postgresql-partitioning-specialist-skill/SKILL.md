---
description: "PostgreSQL Partitioning Specialist skill -- Designs and implements PostgreSQL table partitioning with range, list, and hash strategies for scalable data management"
---

# PostgreSQL Partitioning Specialist Skill

**Category:** Tech Skills > Database > PostgreSQL

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for PostgreSQL Partitioning Specialist operations using PostgreSQL technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for PostgreSQL within Database development.

## When to Use

- When partitioning large tables for query performance
- When implementing time-based data retention with partitions
- When designing partition strategies for multi-tenant applications
- When PostgreSQL-specific technical expertise is required
- When best practices for PostgreSQL technology stack must be applied
- When production-grade PostgreSQL implementation guidance is needed

## Capabilities

- Implement declarative partitioning with range, list, hash
- Design partition pruning for query optimization
- Automate partition creation and maintenance
- Migrate existing tables to partitioned structures
- Configure partition-wise joins and aggregation

## Procedure

1. Analyze data distribution and query patterns
2. Choose partition strategy and key
3. Implement partitioned table structure
4. Configure automatic partition management
5. Migrate existing data to partitioned table
6. Validate partition pruning in query plans

## Output Format

Return structured results:

- **Partition Design**
- **Migration Plan**
- **Maintenance Schedule**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Table Partitioning** | Declarative partitioning in PostgreSQL 10+ |
| **Partition Pruning** | Query optimization with partition elimination |
| **pg_partman** | Automated partition management extension |

## Anti-Hallucination Rules

- Do not assume all queries benefit from partitioning
- Verify partition features in target PostgreSQL version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Partition pruning is active for common queries
- Partition maintenance is automated
- Data distribution is balanced across partitions
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow PostgreSQL community best practices

## Integration Points

- **Companion Agent**: `@postgresql-partitioning-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full PostgreSQL coverage |