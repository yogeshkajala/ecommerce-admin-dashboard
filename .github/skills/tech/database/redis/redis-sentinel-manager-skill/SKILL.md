---
description: "Redis Sentinel Manager skill -- Deploys and manages Redis Sentinel for automatic failover, monitoring, and notification in high availability Redis deployments"
---

# Redis Sentinel Manager Skill

**Category:** Tech Skills > Database > Redis

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Redis Sentinel Manager operations using Redis technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Redis within Database development.

## When to Use

- When deploying Redis Sentinel for high availability
- When configuring automatic failover for Redis master/replica
- When monitoring Redis instance health with Sentinel
- When Redis-specific technical expertise is required
- When best practices for Redis technology stack must be applied
- When production-grade Redis implementation guidance is needed

## Capabilities

- Deploy Sentinel nodes for quorum-based failover
- Configure automatic failover with proper thresholds
- Set up client connections through Sentinel
- Monitor Redis instance health and replication
- Handle split-brain scenarios with proper quorum

## Procedure

1. Design Sentinel topology with odd number of nodes
2. Deploy Sentinel instances across availability zones
3. Configure failover thresholds and timeouts
4. Set up client with Sentinel-aware driver
5. Configure notifications for failover events
6. Test failover procedures regularly

## Output Format

Return structured results:

- **Sentinel Configuration**
- **Failover Testing**
- **Monitoring Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Redis Sentinel** | High availability deployment and configuration |
| **Quorum** | Sentinel quorum and failover consensus |
| **Client Configuration** | Sentinel-aware client connection patterns |

## Anti-Hallucination Rules

- Do not deploy even numbers of Sentinel nodes
- Verify Sentinel features in target Redis version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Quorum prevents split-brain scenarios
- Failover completes within configured timeout
- Clients reconnect automatically after failover
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Redis community best practices

## Integration Points

- **Companion Agent**: `@redis-sentinel-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Redis coverage |
<!-- Technology knowledge base entry for Redis Sentinel Manager in Redis Database -->