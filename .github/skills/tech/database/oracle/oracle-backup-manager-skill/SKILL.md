---
description: "Oracle Backup Manager skill -- Implements Oracle backup strategies with RMAN including full, incremental, and archive log backups for comprehensive data protection"
---

# Oracle Backup Manager Skill

**Category:** Tech Skills > Database > Oracle

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Oracle Backup Manager operations using Oracle technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Oracle within Database development.

## When to Use

- When configuring RMAN backup strategies for Oracle databases
- When implementing block change tracking for fast incremental backups
- When testing disaster recovery with RMAN restore
- When Oracle-specific technical expertise is required
- When best practices for Oracle technology stack must be applied
- When production-grade Oracle implementation guidance is needed

## Capabilities

- Configure RMAN with full and incremental backups
- Enable block change tracking for fast incrementals
- Implement Data Guard for DR with standby databases
- Configure backup encryption and compression
- Test recovery with RMAN restore and recover

## Procedure

1. Assess RPO and RTO requirements
2. Design RMAN backup strategy with retention
3. Enable block change tracking
4. Configure backup destinations and channels
5. Set up Data Guard for DR if needed
6. Test recovery procedures regularly

## Output Format

Return structured results:

- **RMAN Strategy**
- **Data Guard Config**
- **Recovery Test Results**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **RMAN** | Recovery Manager backup and recovery |
| **Data Guard** | Standby database for disaster recovery |
| **Block Change Tracking** | Fast incremental backup optimization |

## Anti-Hallucination Rules

- Do not assume hot backups work without proper archiving mode
- Verify RMAN features in target Oracle version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- RMAN validates backup integrity
- Recovery procedures meet RPO and RTO
- Data Guard switchover is tested regularly
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Oracle community best practices

## Integration Points

- **Companion Agent**: `@oracle-backup-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Oracle coverage |
<!-- Technology knowledge base entry for Oracle Backup Manager in Oracle Database -->
<!-- Technology knowledge base entry for Oracle Backup Manager in Oracle Database -->