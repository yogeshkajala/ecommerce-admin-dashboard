---
description: "PostgreSQL Backup Manager skill -- Implements PostgreSQL backup and recovery strategies with pg_dump, pg_basebackup, and PITR for data protection and disaster recovery"
---

# PostgreSQL Backup Manager Skill

**Category:** Tech Skills > Database > PostgreSQL

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for PostgreSQL Backup Manager operations using PostgreSQL technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for PostgreSQL within Database development.

## When to Use

- When configuring backup strategies for PostgreSQL databases
- When implementing point-in-time recovery capabilities
- When testing disaster recovery procedures
- When PostgreSQL-specific technical expertise is required
- When best practices for PostgreSQL technology stack must be applied
- When production-grade PostgreSQL implementation guidance is needed

## Capabilities

- Configure pg_dump for logical backups
- Set up pg_basebackup for physical backups
- Implement PITR with continuous WAL archiving
- Automate backup schedules with pgBackRest
- Test recovery procedures with restoration drills

## Procedure

1. Assess RPO and RTO requirements
2. Design backup strategy with retention policy
3. Configure backup tools and schedules
4. Set up WAL archiving for PITR
5. Implement backup monitoring and alerting
6. Test recovery procedures regularly

## Output Format

Return structured results:

- **Backup Strategy**
- **Recovery Procedures**
- **Test Results**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **pg_dump** | Logical backup and restore patterns |
| **pgBackRest** | Enterprise backup management tool |
| **PITR** | Point-in-time recovery with WAL archiving |

## Anti-Hallucination Rules

- Do not assume backups are valid without testing restoration
- Verify backup tool compatibility with PostgreSQL version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Backups complete within maintenance windows
- Recovery procedures are tested regularly
- RPO and RTO targets are met
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow PostgreSQL community best practices

## Integration Points

- **Companion Agent**: `@postgresql-backup-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full PostgreSQL coverage |
<!-- Technology knowledge base entry for PostgreSQL Backup Manager in PostgreSQL Database -->