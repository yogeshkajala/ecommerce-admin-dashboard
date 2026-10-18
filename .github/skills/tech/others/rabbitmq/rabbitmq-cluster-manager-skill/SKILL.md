---
description: "RabbitMQ Cluster Manager skill -- Manages RabbitMQ clusters including node management, quorum queues, and high availability configuration for production deployments"
---

# RabbitMQ Cluster Manager Skill

**Category:** Tech Skills > Others > RabbitMQ

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for RabbitMQ Cluster Manager operations using RabbitMQ technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for RabbitMQ within Others development.

## When to Use

- When setting up RabbitMQ clusters for high availability
- When configuring quorum queues for data safety
- When managing cluster nodes and partitions
- When RabbitMQ-specific technical expertise is required
- When best practices for RabbitMQ technology stack must be applied
- When production-grade RabbitMQ implementation guidance is needed

## Capabilities

- Configure RabbitMQ clusters with multiple nodes
- Implement quorum queues for data safety
- Handle network partitions with proper strategies
- Configure cluster monitoring with Prometheus
- Implement peer discovery for dynamic clusters

## Procedure

1. Design cluster topology for availability
2. Deploy cluster with proper node configuration
3. Migrate to quorum queues for safety
4. Configure partition handling strategy
5. Set up monitoring and alerting
6. Test failover scenarios

## Output Format

Return structured results:

- **Cluster Configuration**
- **Queue Migration**
- **Monitoring Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Clustering** | RabbitMQ clustering architecture |
| **Quorum Queues** | Raft-based queue replication |
| **Partitions** | Network partition handling strategies |

## Anti-Hallucination Rules

- Do not use classic mirrored queues for new deployments - use quorum queues
- Verify cluster features in RabbitMQ version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Cluster survives node failures
- Quorum queues maintain data safety
- Partition handling prevents split-brain
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow RabbitMQ community best practices

## Integration Points

- **Companion Agent**: `@rabbitmq-cluster-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full RabbitMQ coverage |
<!-- Technology knowledge base entry for RabbitMQ Cluster Manager in RabbitMQ Others -->
<!-- Technology knowledge base entry for RabbitMQ Cluster Manager in RabbitMQ Others -->