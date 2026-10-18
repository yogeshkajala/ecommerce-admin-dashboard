---
description: "Elasticsearch Cluster Manager skill -- Manages Elasticsearch clusters including node configuration, shard allocation, and cluster health monitoring for production stability"
---

# Elasticsearch Cluster Manager Skill

**Category:** Tech Skills > Database > Elasticsearch

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Elasticsearch Cluster Manager operations using Elasticsearch technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Elasticsearch within Database development.

## When to Use

- When deploying Elasticsearch clusters for production
- When managing shard allocation and rebalancing
- When monitoring cluster health and performance
- When Elasticsearch-specific technical expertise is required
- When best practices for Elasticsearch technology stack must be applied
- When production-grade Elasticsearch implementation guidance is needed

## Capabilities

- Configure cluster nodes with proper roles
- Manage shard allocation and routing
- Monitor cluster health with _cluster/health API
- Configure cross-cluster replication
- Handle cluster recovery and split-brain prevention

## Procedure

1. Design cluster topology with node roles
2. Configure discovery and master election
3. Set up shard allocation awareness
4. Configure monitoring and alerting
5. Implement backup with snapshot API
6. Test recovery procedures

## Output Format

Return structured results:

- **Cluster Configuration**
- **Health Dashboard**
- **Recovery Procedures**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Cluster Configuration** | Node roles and discovery settings |
| **Shard Allocation** | Allocation awareness and filtering |
| **Recovery** | Cluster recovery and resilience settings |

## Anti-Hallucination Rules

- Do not run single-node clusters in production without understanding limitations
- Verify cluster features in target Elasticsearch version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Cluster has sufficient master-eligible nodes
- Shard allocation prevents data loss
- Recovery procedures are tested and documented
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Elasticsearch community best practices

## Integration Points

- **Companion Agent**: `@elasticsearch-cluster-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Elasticsearch coverage |
<!-- Technology knowledge base entry for Elasticsearch Cluster Manager in Elasticsearch Database -->