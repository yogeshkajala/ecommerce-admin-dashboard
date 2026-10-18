---
description: "Cassandra Backup Manager skill -- Implements Cassandra backup and restore strategies with snapshots, incremental backups, and Medusa for data protection"
---

# Cassandra Backup Manager Skill

**Category:** Tech Skills > Database > Cassandra

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Cassandra Backup Manager operations using Cassandra technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Cassandra within Database development.

## When to Use

- When configuring Cassandra backup strategies
- When implementing snapshot-based backups
- When testing restore procedures for disaster recovery
- When Cassandra-specific technical expertise is required
- When best practices for Cassandra technology stack must be applied
- When production-grade Cassandra implementation guidance is needed

## Capabilities

- Create snapshots with nodetool snapshot
- Configure incremental backups
- Use Medusa for automated backup management
- Implement backup verification
- Test restore procedures on alternate clusters

## Procedure

1. Assess backup requirements and retention
2. Configure snapshot-based backup schedule
3. Set up Medusa for backup automation
4. Configure backup storage destination
5. Implement backup monitoring and alerting
6. Test restore procedures regularly

## Output Format

Return structured results:

- **Backup Strategy**
- **Medusa Configuration**
- **Restore Procedures**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Cassandra Backups** | Snapshot and incremental backup patterns |
| **Medusa** | Automated backup management for Cassandra |
| **Restore** | Restore procedures and validation |

## Anti-Hallucination Rules

- Do not assume snapshots alone provide consistent cluster backups
- Verify backup tool compatibility with Cassandra version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Backups are verified with test restores
- Retention policy meets compliance requirements
- Restore procedures are documented and tested
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Cassandra community best practices

## Integration Points

- **Companion Agent**: `@cassandra-backup-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Cassandra coverage |
<!-- Technology knowledge base entry for Cassandra Backup Manager in Cassandra Database -->
<!-- Technology knowledge base entry for Cassandra Backup Manager in Cassandra Database -->