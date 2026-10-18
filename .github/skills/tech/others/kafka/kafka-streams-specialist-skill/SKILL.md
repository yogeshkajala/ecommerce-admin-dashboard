---
description: "Kafka Streams Specialist skill -- Builds stream processing applications with Kafka Streams including topology design, state stores, and windowed aggregations"
---

# Kafka Streams Specialist Skill

**Category:** Tech Skills > Others > Apache Kafka

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Kafka Streams Specialist operations using Apache Kafka technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Apache Kafka within Others development.

## When to Use

- When building stream processing with Kafka Streams
- When implementing windowed aggregations and joins
- When managing state stores for stateful processing
- When Apache Kafka-specific technical expertise is required
- When best practices for Apache Kafka technology stack must be applied
- When production-grade Apache Kafka implementation guidance is needed

## Capabilities

- Design stream processing topologies
- Implement windowed aggregations
- Configure state stores for stateful processing
- Build stream-table joins for enrichment
- Handle late-arriving events with grace periods

## Procedure

1. Design processing topology
2. Implement stream transformations
3. Add state stores for stateful operations
4. Configure windowing for aggregations
5. Handle late arrivals and out-of-order events
6. Test with TopologyTestDriver

## Output Format

Return structured results:

- **Stream Topology**
- **State Store Config**
- **Window Definitions**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Kafka Streams** | Stream processing API and patterns |
| **State Stores** | Stateful processing and state management |
| **Windowing** | Time-based aggregation patterns |

## Anti-Hallucination Rules

- Do not use global state stores for high-volume data
- Verify Kafka Streams features in target version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Topology handles all event types
- State stores are properly cleaned up
- Windows handle late arrivals correctly
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Apache Kafka community best practices

## Integration Points

- **Companion Agent**: `@kafka-streams-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Apache Kafka coverage |
<!-- Technology knowledge base entry for Kafka Streams Specialist in Apache Kafka Others -->
<!-- Technology knowledge base entry for Kafka Streams Specialist in Apache Kafka Others -->