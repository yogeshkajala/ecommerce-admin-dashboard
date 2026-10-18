---
description: "Cassandra Replication Specialist skill -- Configures Cassandra replication strategies including NetworkTopologyStrategy, consistency levels, and multi-datacenter replication"
---

# Cassandra Replication Specialist Skill

**Category:** Tech Skills > Database > Cassandra

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Cassandra Replication Specialist operations using Cassandra technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Cassandra within Database development.

## When to Use

- When configuring replication factors for keyspaces
- When choosing consistency levels for read/write operations
- When setting up multi-datacenter replication
- When Cassandra-specific technical expertise is required
- When best practices for Cassandra technology stack must be applied
- When production-grade Cassandra implementation guidance is needed

## Capabilities

- Configure NetworkTopologyStrategy with proper RF per DC
- Choose consistency levels for read/write balance
- Implement multi-DC replication for disaster recovery
- Handle consistency across datacenters
- Monitor replication and hints delivery

## Procedure

1. Design replication strategy per keyspace
2. Configure replication factor for each datacenter
3. Choose consistency levels for operations
4. Test consistency behavior under failure
5. Monitor hint delivery and storage
6. Validate data consistency across DCs

## Output Format

Return structured results:

- **Replication Config**
- **Consistency Strategy**
- **DC Topology**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Replication** | Replication strategy and factor selection |
| **Consistency Levels** | Read/write consistency trade-offs |
| **Multi-DC** | Cross-datacenter replication patterns |

## Anti-Hallucination Rules

- Do not use SimpleStrategy in production multi-DC deployments
- Verify consistency level behavior in target Cassandra version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Replication factor provides required fault tolerance
- Consistency levels balance performance and correctness
- Hints are delivered within acceptable timeframes
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Cassandra community best practices

## Integration Points

- **Companion Agent**: `@cassandra-replication-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Cassandra coverage |