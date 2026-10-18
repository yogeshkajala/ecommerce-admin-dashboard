---
description: "PostgreSQL Replication Specialist skill -- Configures PostgreSQL replication including streaming replication, logical replication, and high availability with Patroni or pg_auto_failover"
---

# PostgreSQL Replication Specialist Skill

**Category:** Tech Skills > Database > PostgreSQL

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for PostgreSQL Replication Specialist operations using PostgreSQL technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for PostgreSQL within Database development.

## When to Use

- When setting up streaming replication for high availability
- When configuring logical replication for selective data sync
- When implementing automatic failover with Patroni
- When PostgreSQL-specific technical expertise is required
- When best practices for PostgreSQL technology stack must be applied
- When production-grade PostgreSQL implementation guidance is needed

## Capabilities

- Configure streaming replication with synchronous mode
- Set up logical replication with publication/subscription
- Implement Patroni for automatic failover
- Monitor replication lag and health
- Design multi-region replication topologies

## Procedure

1. Assess replication requirements and topology
2. Configure primary with WAL archiving
3. Set up streaming replicas with proper recovery
4. Configure logical replication if selective sync needed
5. Implement failover automation with Patroni
6. Monitor replication lag and throughput

## Output Format

Return structured results:

- **Replication Configuration**
- **Failover Setup**
- **Monitoring Dashboard**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Streaming Replication** | Physical replication configuration and monitoring |
| **Logical Replication** | Publication/subscription patterns |
| **Patroni** | High availability and automatic failover |

## Anti-Hallucination Rules

- Do not assume zero data loss without synchronous replication
- Verify replication features in target PostgreSQL version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Replication lag stays within defined thresholds
- Failover completes within recovery time objective
- No data loss during planned switchover
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow PostgreSQL community best practices

## Integration Points

- **Companion Agent**: `@postgresql-replication-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full PostgreSQL coverage |