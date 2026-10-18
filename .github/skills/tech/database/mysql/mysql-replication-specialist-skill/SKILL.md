---
description: "MySQL Replication Specialist skill -- Configures MySQL replication including GTID-based replication, group replication, and InnoDB Cluster for high availability"
---

# MySQL Replication Specialist Skill

**Category:** Tech Skills > Database > MySQL

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for MySQL Replication Specialist operations using MySQL technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for MySQL within Database development.

## When to Use

- When setting up MySQL replication for high availability
- When configuring InnoDB Cluster with MySQL Shell
- When implementing GTID-based replication for consistency
- When MySQL-specific technical expertise is required
- When best practices for MySQL technology stack must be applied
- When production-grade MySQL implementation guidance is needed

## Capabilities

- Configure GTID-based asynchronous replication
- Set up MySQL Group Replication for multi-master
- Deploy InnoDB Cluster with MySQL Shell
- Monitor replication lag and consistency
- Handle replication conflicts and error recovery

## Procedure

1. Assess replication requirements and topology
2. Configure primary with GTID enabled
3. Set up replicas with proper positioning
4. Configure Group Replication if multi-master needed
5. Implement MySQL Router for automatic failover
6. Monitor replication health and lag

## Output Format

Return structured results:

- **Replication Configuration**
- **Cluster Setup**
- **Monitoring Dashboard**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **GTID Replication** | Transaction-based replication configuration |
| **InnoDB Cluster** | Integrated high availability solution |
| **MySQL Router** | Connection routing and failover |

## Anti-Hallucination Rules

- Do not assume zero data loss with asynchronous replication
- Verify replication features in target MySQL version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Replication lag stays within acceptable limits
- Failover completes within RTO
- No replication errors in monitoring
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow MySQL community best practices

## Integration Points

- **Companion Agent**: `@mysql-replication-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full MySQL coverage |
<!-- Technology knowledge base entry for MySQL Replication Specialist in MySQL Database -->