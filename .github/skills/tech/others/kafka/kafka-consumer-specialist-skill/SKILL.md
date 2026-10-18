---
description: "Kafka Consumer Specialist skill -- Implements Kafka consumers with proper group management, offset handling, and rebalancing strategies for reliable message consumption"
---

# Kafka Consumer Specialist Skill

**Category:** Tech Skills > Others > Apache Kafka

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Kafka Consumer Specialist operations using Apache Kafka technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Apache Kafka within Others development.

## When to Use

- When building Kafka consumers for event processing
- When managing consumer groups and offset commits
- When implementing rebalancing strategies for availability
- When Apache Kafka-specific technical expertise is required
- When best practices for Apache Kafka technology stack must be applied
- When production-grade Apache Kafka implementation guidance is needed

## Capabilities

- Configure consumer groups with proper settings
- Implement manual and automatic offset commits
- Handle consumer rebalancing with cooperative strategy
- Implement idempotent message processing
- Monitor consumer lag and health

## Procedure

1. Design consumer group topology
2. Configure offset commit strategy
3. Implement message processing logic
4. Handle rebalancing with cooperative protocol
5. Monitor consumer lag
6. Test with failure and rebalance scenarios

## Output Format

Return structured results:

- **Consumer Configuration**
- **Offset Strategy**
- **Monitoring Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Consumer Config** | Key consumer configuration parameters |
| **Offset Management** | Commit strategies and semantics |
| **Rebalancing** | Consumer group rebalancing protocols |

## Anti-Hallucination Rules

- Do not commit offsets before processing completes
- Verify consumer features in target Kafka version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- No message loss during rebalancing
- Consumer lag is monitored
- Processing is idempotent
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Apache Kafka community best practices

## Integration Points

- **Companion Agent**: `@kafka-consumer-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Apache Kafka coverage |
<!-- Technology knowledge base entry for Kafka Consumer Specialist in Apache Kafka Others -->
<!-- Technology knowledge base entry for Kafka Consumer Specialist in Apache Kafka Others -->