---
description: "Kafka Connect Specialist skill -- Implements Kafka Connect for data integration with source and sink connectors, transforms, and connector management"
---

# Kafka Connect Specialist Skill

**Category:** Tech Skills > Others > Apache Kafka

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Kafka Connect Specialist operations using Apache Kafka technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Apache Kafka within Others development.

## When to Use

- When integrating external systems with Kafka Connect
- When configuring source and sink connectors
- When implementing Single Message Transforms for data routing
- When Apache Kafka-specific technical expertise is required
- When best practices for Apache Kafka technology stack must be applied
- When production-grade Apache Kafka implementation guidance is needed

## Capabilities

- Configure source connectors for data ingestion
- Set up sink connectors for data export
- Implement Single Message Transforms
- Manage connectors with REST API
- Monitor connector health and throughput

## Procedure

1. Identify source and sink systems
2. Choose appropriate connectors
3. Configure connector properties
4. Add transforms for data routing
5. Deploy and monitor connectors
6. Handle connector failures and restarts

## Output Format

Return structured results:

- **Connector Configuration**
- **SMT Setup**
- **Monitoring Config**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Kafka Connect** | Connector framework and configuration |
| **SMTs** | Single Message Transform patterns |
| **Connector Management** | REST API for connector lifecycle |

## Anti-Hallucination Rules

- Do not run connectors in standalone mode for production
- Verify connector plugin compatibility with Connect version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Connectors run reliably
- SMTs transform data correctly
- Failures are detected and recovered
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Apache Kafka community best practices

## Integration Points

- **Companion Agent**: `@kafka-connect-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Apache Kafka coverage |
<!-- Technology knowledge base entry for Kafka Connect Specialist in Apache Kafka Others -->
<!-- Technology knowledge base entry for Kafka Connect Specialist in Apache Kafka Others -->