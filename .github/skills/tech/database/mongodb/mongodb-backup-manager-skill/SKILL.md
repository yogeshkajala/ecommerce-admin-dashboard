---
description: "MongoDB Backup Manager skill -- Implements MongoDB backup strategies with mongodump, filesystem snapshots, and Atlas backup for data protection and recovery"
---

# MongoDB Backup Manager Skill

**Category:** Tech Skills > Database > MongoDB

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for MongoDB Backup Manager operations using MongoDB technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for MongoDB within Database development.

## When to Use

- When configuring backup strategies for MongoDB deployments
- When implementing point-in-time recovery with oplog
- When testing disaster recovery procedures
- When MongoDB-specific technical expertise is required
- When best practices for MongoDB technology stack must be applied
- When production-grade MongoDB implementation guidance is needed

## Capabilities

- Configure mongodump for logical backups
- Implement filesystem snapshots for physical backups
- Set up oplog-based point-in-time recovery
- Use Atlas backup for cloud deployments
- Test recovery procedures with regular drills

## Procedure

1. Assess RPO and RTO requirements
2. Choose backup method based on deployment type
3. Configure backup schedule and retention
4. Set up oplog capture for PITR capability
5. Implement backup monitoring
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
| **mongodump** | Logical backup tool for MongoDB |
| **Atlas Backup** | Cloud-native backup for MongoDB Atlas |
| **Oplog** | Point-in-time recovery with operation log |

## Anti-Hallucination Rules

- Do not assume mongodump is consistent for sharded clusters without --oplog
- Verify backup tool compatibility with MongoDB version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Backups are tested with regular restoration drills
- Recovery procedures meet RPO and RTO
- Sharded cluster backups maintain consistency
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow MongoDB community best practices

## Integration Points

- **Companion Agent**: `@mongodb-backup-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full MongoDB coverage |
<!-- Technology knowledge base entry for MongoDB Backup Manager in MongoDB Database -->
<!-- Technology knowledge base entry for MongoDB Backup Manager in MongoDB Database -->