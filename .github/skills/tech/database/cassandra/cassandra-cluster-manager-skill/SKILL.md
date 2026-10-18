---
description: "Cassandra Cluster Manager skill -- Deploys and manages Cassandra clusters including node operations, compaction strategies, and repair management for production stability"
---

# Cassandra Cluster Manager Skill

**Category:** Tech Skills > Database > Cassandra

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Cassandra Cluster Manager operations using Cassandra technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Cassandra within Database development.

## When to Use

- When deploying Cassandra clusters with proper topology
- When managing node operations: add, decommission, replace
- When configuring compaction and repair schedules
- When Cassandra-specific technical expertise is required
- When best practices for Cassandra technology stack must be applied
- When production-grade Cassandra implementation guidance is needed

## Capabilities

- Deploy multi-datacenter Cassandra clusters
- Manage node operations with nodetool
- Configure compaction strategies per table
- Schedule repairs for data consistency
- Monitor cluster health with JMX metrics

## Procedure

1. Design cluster topology with rack awareness
2. Deploy seed nodes and configure snitch
3. Configure compaction strategy per workload
4. Schedule regular repair operations
5. Set up monitoring with Prometheus and Grafana
6. Test node failure and recovery

## Output Format

Return structured results:

- **Cluster Configuration**
- **Operations Runbook**
- **Monitoring Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Cassandra Operations** | Cluster management and nodetool operations |
| **Compaction** | Strategy selection for workload types |
| **Repair** | Anti-entropy repair scheduling |

## Anti-Hallucination Rules

- Do not skip repairs - data inconsistency will accumulate
- Verify nodetool commands in target Cassandra version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Rack awareness prevents data center failures
- Compaction strategy matches workload
- Repairs complete within gc_grace_seconds
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Cassandra community best practices

## Integration Points

- **Companion Agent**: `@cassandra-cluster-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Cassandra coverage |
<!-- Technology knowledge base entry for Cassandra Cluster Manager in Cassandra Database -->