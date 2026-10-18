---
description: "MySQL Migration Specialist skill -- Plans and executes database migrations involving MySQL with schema conversion, data transfer, and application compatibility validation"
---

# MySQL Migration Specialist Skill

**Category:** Tech Skills > Database > MySQL

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for MySQL Migration Specialist operations using MySQL technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for MySQL within Database development.

## When to Use

- When migrating to or from MySQL databases
- When upgrading MySQL major versions
- When converting between MySQL and MariaDB
- When MySQL-specific technical expertise is required
- When best practices for MySQL technology stack must be applied
- When production-grade MySQL implementation guidance is needed

## Capabilities

- Plan major version upgrades with compatibility checks
- Migrate data between MySQL and other databases
- Handle character set and collation conversions
- Use MySQL Shell for dump and load operations
- Validate application compatibility post-migration

## Procedure

1. Assess migration complexity and compatibility
2. Test upgrade on staging environment
3. Convert schema if migrating between platforms
4. Execute data migration with validation
5. Test application behavior post-migration
6. Plan cutover with rollback strategy

## Output Format

Return structured results:

- **Migration Plan**
- **Compatibility Report**
- **Validation Results**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **MySQL Upgrade** | Major version upgrade procedures |
| **MySQL Shell** | Dump/load utilities for migration |
| **Compatibility** | SQL mode and feature compatibility checking |

## Anti-Hallucination Rules

- Do not assume SQL compatibility between MySQL versions
- Verify deprecated features before upgrading
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Data integrity verified post-migration
- Application queries return correct results
- Performance meets baseline expectations
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow MySQL community best practices

## Integration Points

- **Companion Agent**: `@mysql-migration-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full MySQL coverage |
<!-- Technology knowledge base entry for MySQL Migration Specialist in MySQL Database -->
<!-- Technology knowledge base entry for MySQL Migration Specialist in MySQL Database -->