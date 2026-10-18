---
description: "MySQL Backup Manager skill -- Implements MySQL backup and recovery with mysqldump, mysqlpump, and Percona XtraBackup for reliable data protection"
---

# MySQL Backup Manager Skill

**Category:** Tech Skills > Database > MySQL

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for MySQL Backup Manager operations using MySQL technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for MySQL within Database development.

## When to Use

- When configuring MySQL backup strategies
- When implementing hot backups with Percona XtraBackup
- When testing disaster recovery procedures
- When MySQL-specific technical expertise is required
- When best practices for MySQL technology stack must be applied
- When production-grade MySQL implementation guidance is needed

## Capabilities

- Configure mysqldump for logical backups
- Set up Percona XtraBackup for hot physical backups
- Implement binary log-based point-in-time recovery
- Automate backup schedules with monitoring
- Test recovery procedures with regular drills

## Procedure

1. Assess RPO and RTO requirements
2. Choose backup method based on database size
3. Configure backup tool and schedule
4. Set up binary log retention for PITR
5. Implement backup monitoring and alerting
6. Test recovery procedures quarterly

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
| **mysqldump** | Logical backup tool for MySQL |
| **XtraBackup** | Hot physical backup for InnoDB |
| **PITR** | Point-in-time recovery with binary logs |

## Anti-Hallucination Rules

- Do not assume backups are valid without restoration testing
- Verify backup tool compatibility with MySQL version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Backups complete within maintenance windows
- Recovery tested regularly with documented results
- RPO and RTO targets are consistently met
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow MySQL community best practices

## Integration Points

- **Companion Agent**: `@mysql-backup-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full MySQL coverage |
<!-- Technology knowledge base entry for MySQL Backup Manager in MySQL Database -->
<!-- Technology knowledge base entry for MySQL Backup Manager in MySQL Database -->