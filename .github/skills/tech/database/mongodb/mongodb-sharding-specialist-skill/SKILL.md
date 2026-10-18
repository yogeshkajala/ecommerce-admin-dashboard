---
description: "MongoDB Sharding Specialist skill -- Implements MongoDB sharding for horizontal scaling including shard key selection, chunk management, and balanced data distribution"
---

# MongoDB Sharding Specialist Skill

**Category:** Tech Skills > Database > MongoDB

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for MongoDB Sharding Specialist operations using MongoDB technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for MongoDB within Database development.

## When to Use

- When implementing horizontal scaling with MongoDB sharding
- When selecting shard keys for optimal data distribution
- When managing chunk splitting and balancing
- When MongoDB-specific technical expertise is required
- When best practices for MongoDB technology stack must be applied
- When production-grade MongoDB implementation guidance is needed

## Capabilities

- Select optimal shard keys based on query patterns
- Configure sharded clusters with config servers
- Manage chunk splitting and balancer settings
- Implement zone-based sharding for data locality
- Monitor shard distribution and balancing

## Procedure

1. Analyze data distribution and query patterns
2. Select shard key with proper cardinality
3. Deploy config servers and shard nodes
4. Enable sharding on database and collections
5. Configure zones for data placement requirements
6. Monitor balancing and distribution

## Output Format

Return structured results:

- **Shard Key Analysis**
- **Cluster Configuration**
- **Distribution Report**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Shard Key Selection** | Choosing shard keys for balanced distribution |
| **Sharding Architecture** | Config servers, mongos, and shard components |
| **Zone Sharding** | Geographic data placement with zones |

## Anti-Hallucination Rules

- Do not choose monotonically increasing shard keys
- Verify sharding features in target MongoDB version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Data is evenly distributed across shards
- Queries target specific shards where possible
- Balancer maintains even distribution
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow MongoDB community best practices

## Integration Points

- **Companion Agent**: `@mongodb-sharding-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full MongoDB coverage |
<!-- Technology knowledge base entry for MongoDB Sharding Specialist in MongoDB Database -->