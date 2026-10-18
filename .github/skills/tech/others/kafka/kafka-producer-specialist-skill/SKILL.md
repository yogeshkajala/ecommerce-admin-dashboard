---
description: "Kafka Producer Specialist skill -- Implements Kafka producers with proper partitioning, serialization, and delivery guarantees for reliable message publishing"
---

# Kafka Producer Specialist Skill

**Category:** Tech Skills > Others > Apache Kafka

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Kafka Producer Specialist operations using Apache Kafka technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Apache Kafka within Others development.

## When to Use

- When building Kafka producers for event publishing
- When configuring producer reliability and performance
- When implementing custom partitioning strategies
- When Apache Kafka-specific technical expertise is required
- When best practices for Apache Kafka technology stack must be applied
- When production-grade Apache Kafka implementation guidance is needed

## Capabilities

- Configure producers with proper acknowledgement settings
- Implement custom partitioners for message routing
- Configure serialization with Avro or Protobuf
- Handle producer errors and retries
- Optimize throughput with batching and compression

## Procedure

1. Design producer configuration for requirements
2. Choose serialization format
3. Configure acks and retry settings
4. Implement error handling and callbacks
5. Optimize batching and compression
6. Test with different failure scenarios

## Output Format

Return structured results:

- **Producer Configuration**
- **Serialization Setup**
- **Error Handling**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Producer Config** | Key producer configuration parameters |
| **Delivery Semantics** | At-least-once and exactly-once delivery |
| **Serialization** | Avro, Protobuf, JSON schema patterns |

## Anti-Hallucination Rules

- Do not use acks=0 for critical data without understanding trade-offs
- Verify producer features in target Kafka version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Messages are delivered reliably
- Serialization is consistent
- Error handling covers all failure modes
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Apache Kafka community best practices

## Integration Points

- **Companion Agent**: `@kafka-producer-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Apache Kafka coverage |
<!-- Technology knowledge base entry for Kafka Producer Specialist in Apache Kafka Others -->