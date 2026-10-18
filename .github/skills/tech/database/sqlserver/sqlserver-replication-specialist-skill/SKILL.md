---
description: "SQL Server Replication Specialist skill -- Configures SQL Server replication and Always On availability groups for high availability and disaster recovery"
---

# SQL Server Replication Specialist Skill

**Category:** Tech Skills > Database > SQL Server

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for SQL Server Replication Specialist operations using SQL Server technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for SQL Server within Database development.

## When to Use

- When setting up Always On availability groups for HA
- When configuring transactional replication for data distribution
- When implementing distributed availability groups across regions
- When SQL Server-specific technical expertise is required
- When best practices for SQL Server technology stack must be applied
- When production-grade SQL Server implementation guidance is needed

## Capabilities

- Configure Always On availability groups with synchronous commit
- Set up transactional replication for data distribution
- Implement distributed AG for multi-region HA
- Configure read replicas for read scale-out
- Monitor replication health and latency

## Procedure

1. Assess HA and DR requirements
2. Configure Windows failover cluster or Linux Pacemaker
3. Set up availability group with proper replicas
4. Configure synchronous/asynchronous commit per replica
5. Set up monitoring and alerting
6. Test failover and recovery procedures

## Output Format

Return structured results:

- **AG Configuration**
- **Replication Setup**
- **Failover Procedures**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Always On AG** | Availability group configuration and management |
| **Transactional Replication** | Data distribution and subscriber management |
| **Distributed AG** | Cross-region availability group patterns |

## Anti-Hallucination Rules

- Do not assume synchronous commit for cross-region replicas
- Verify AG features in target SQL Server edition
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Failover completes within RTO requirements
- Data loss is within RPO limits
- Read replicas serve queries correctly
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow SQL Server community best practices

## Integration Points

- **Companion Agent**: `@sqlserver-replication-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full SQL Server coverage |