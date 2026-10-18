---
description: "SQL Server Backup Manager skill -- Implements SQL Server backup strategies with full, differential, and log backups for comprehensive data protection and PITR"
---

# SQL Server Backup Manager Skill

**Category:** Tech Skills > Database > SQL Server

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for SQL Server Backup Manager operations using SQL Server technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for SQL Server within Database development.

## When to Use

- When configuring SQL Server backup strategies
- When implementing point-in-time recovery with log backups
- When testing disaster recovery with backup restoration
- When SQL Server-specific technical expertise is required
- When best practices for SQL Server technology stack must be applied
- When production-grade SQL Server implementation guidance is needed

## Capabilities

- Configure full, differential, and transaction log backups
- Implement backup compression and encryption
- Set up backup to Azure Blob Storage
- Manage backup retention and cleanup
- Test recovery with RESTORE VERIFYONLY and actual restores

## Procedure

1. Assess RPO and RTO requirements
2. Design backup schedule with proper chain
3. Configure backup destination and retention
4. Enable backup compression and encryption
5. Set up monitoring for backup success
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
| **SQL Server Backup** | Backup strategy and recovery models |
| **Backup Compression** | Compression and encryption settings |
| **Azure Backup** | SQL Server backup to Azure Blob Storage |

## Anti-Hallucination Rules

- Do not assume SIMPLE recovery model allows PITR
- Verify backup features in target SQL Server edition
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Backup chain is unbroken for PITR
- Recovery procedures meet RPO and RTO
- Backup encryption protects sensitive data
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow SQL Server community best practices

## Integration Points

- **Companion Agent**: `@sqlserver-backup-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full SQL Server coverage |
<!-- Technology knowledge base entry for SQL Server Backup Manager in SQL Server Database -->