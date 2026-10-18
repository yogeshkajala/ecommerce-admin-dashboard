---
description: "Redis Cluster Specialist skill -- Deploys and manages Redis Cluster for horizontal scaling including slot management, resharding, and client configuration"
---

# Redis Cluster Specialist Skill

**Category:** Tech Skills > Database > Redis

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Redis Cluster Specialist operations using Redis technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Redis within Database development.

## When to Use

- When deploying Redis Cluster for horizontal scaling
- When managing hash slots and resharding operations
- When configuring Redis Cluster clients for proper routing
- When Redis-specific technical expertise is required
- When best practices for Redis technology stack must be applied
- When production-grade Redis implementation guidance is needed

## Capabilities

- Deploy Redis Cluster with proper topology
- Manage hash slot distribution and resharding
- Configure client-side routing with smart clients
- Handle cluster failover and recovery
- Monitor cluster health and slot distribution

## Procedure

1. Design cluster topology with node placement
2. Deploy cluster with redis-cli --cluster
3. Configure hash slot distribution
4. Set up client with cluster-aware driver
5. Implement monitoring for cluster health
6. Test failover and recovery procedures

## Output Format

Return structured results:

- **Cluster Configuration**
- **Slot Distribution**
- **Failover Procedures**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Redis Cluster** | Cluster specification and deployment |
| **Hash Slots** | Slot management and distribution |
| **Client Routing** | MOVED and ASK redirect handling |

## Anti-Hallucination Rules

- Do not assume all Redis commands work in cluster mode
- Verify cluster features in target Redis version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Slots are evenly distributed across nodes
- Failover completes within acceptable time
- Client handles redirects properly
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Redis community best practices

## Integration Points

- **Companion Agent**: `@redis-cluster-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Redis coverage |
<!-- Technology knowledge base entry for Redis Cluster Specialist in Redis Database -->
<!-- Technology knowledge base entry for Redis Cluster Specialist in Redis Database -->