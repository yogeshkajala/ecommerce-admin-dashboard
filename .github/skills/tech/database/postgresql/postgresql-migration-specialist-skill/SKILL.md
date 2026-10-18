---
description: "PostgreSQL Migration Specialist skill -- Plans and executes database migrations to and from PostgreSQL with schema conversion, data migration, and compatibility testing"
---

# PostgreSQL Migration Specialist Skill

**Category:** Tech Skills > Database > PostgreSQL

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for PostgreSQL Migration Specialist operations using PostgreSQL technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for PostgreSQL within Database development.

## When to Use

- When migrating databases to PostgreSQL from other RDBMS
- When executing schema migrations with proper versioning
- When handling data type conversions and compatibility issues
- When PostgreSQL-specific technical expertise is required
- When best practices for PostgreSQL technology stack must be applied
- When production-grade PostgreSQL implementation guidance is needed

## Capabilities

- Convert schemas from Oracle, MySQL, SQL Server to PostgreSQL
- Migrate data with minimal downtime using logical replication
- Handle data type mappings and compatibility
- Use pgLoader for efficient bulk data migration
- Implement schema versioning with Flyway or Liquibase

## Procedure

1. Assess source database for migration complexity
2. Convert schema with data type mappings
3. Migrate data with pgLoader or custom ETL
4. Validate data integrity post-migration
5. Test application compatibility
6. Plan cutover with minimal downtime

## Output Format

Return structured results:

- **Migration Plan**
- **Schema Conversion**
- **Validation Report**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **pgLoader** | Bulk data migration tool for PostgreSQL |
| **Flyway** | Schema versioning and migration management |
| **AWS SCT** | Schema conversion tool for cloud migrations |

## Anti-Hallucination Rules

- Do not assume feature parity between source and PostgreSQL
- Verify data type compatibility before migration
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Data integrity is verified post-migration
- Application queries return identical results
- Performance meets or exceeds source database
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow PostgreSQL community best practices

## Integration Points

- **Companion Agent**: `@postgresql-migration-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full PostgreSQL coverage |