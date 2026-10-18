---
description: "Kafka Cluster Manager skill -- Manages Kafka clusters including topic configuration, partition management, and cluster monitoring for production operations"
---

# Kafka Cluster Manager Skill

**Category:** Tech Skills > Others > Apache Kafka

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Kafka Cluster Manager operations using Apache Kafka technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Apache Kafka within Others development.

## When to Use

- When managing Kafka cluster operations and configuration
- When tuning topic and partition settings for performance
- When monitoring cluster health and performance
- When Apache Kafka-specific technical expertise is required
- When best practices for Apache Kafka technology stack must be applied
- When production-grade Apache Kafka implementation guidance is needed

## Capabilities

- Configure topics with proper partition and replication settings
- Manage partition reassignment for balanced distribution
- Monitor cluster health with JMX metrics
- Configure log retention and compaction
- Implement cluster security with SASL and TLS

## Procedure

1. Design topic configuration strategy
2. Create topics with proper settings
3. Monitor cluster metrics and health
4. Rebalance partitions when needed
5. Configure security and access control
6. Plan capacity for growth

## Output Format

Return structured results:

- **Cluster Configuration**
- **Topic Design**
- **Monitoring Dashboard**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Kafka Operations** | Cluster management best practices |
| **Topic Configuration** | Partition and retention settings |
| **Monitoring** | JMX metrics and monitoring tools |

## Anti-Hallucination Rules

- Do not reduce replication factor below 3 for production topics
- Verify Kafka features in target cluster version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Topics are properly replicated
- Cluster is balanced across brokers
- Monitoring detects issues early
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Apache Kafka community best practices

## Integration Points

- **Companion Agent**: `@kafka-cluster-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Apache Kafka coverage |
<!-- Technology knowledge base entry for Kafka Cluster Manager in Apache Kafka Others -->
<!-- Technology knowledge base entry for Kafka Cluster Manager in Apache Kafka Others -->