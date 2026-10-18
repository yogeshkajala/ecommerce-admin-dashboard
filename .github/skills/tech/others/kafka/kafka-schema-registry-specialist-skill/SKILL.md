---
description: "Kafka Schema Registry Specialist skill -- Manages Kafka Schema Registry for schema evolution with Avro, Protobuf, and JSON Schema compatibility enforcement"
---

# Kafka Schema Registry Specialist Skill

**Category:** Tech Skills > Others > Apache Kafka

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Kafka Schema Registry Specialist operations using Apache Kafka technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Apache Kafka within Others development.

## When to Use

- When managing schema evolution for Kafka topics
- When configuring schema compatibility rules
- When implementing schema validation in producers and consumers
- When Apache Kafka-specific technical expertise is required
- When best practices for Apache Kafka technology stack must be applied
- When production-grade Apache Kafka implementation guidance is needed

## Capabilities

- Register and manage schemas with Schema Registry
- Configure compatibility modes per subject
- Implement schema evolution with backward/forward compatibility
- Integrate schema validation in producers
- Handle schema migration across versions

## Procedure

1. Design schema for events
2. Register initial schema
3. Configure compatibility mode
4. Evolve schema with proper compatibility
5. Test schema evolution
6. Monitor schema usage and compatibility

## Output Format

Return structured results:

- **Schema Definitions**
- **Compatibility Config**
- **Evolution Plan**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Schema Registry** | Schema management and compatibility |
| **Avro** | Schema evolution with Avro |
| **Compatibility** | Schema compatibility modes and rules |

## Anti-Hallucination Rules

- Do not break schema compatibility without migration plan
- Verify Schema Registry compatibility with Kafka version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Schemas evolve without breaking consumers
- Compatibility rules prevent incompatible changes
- Schema versions are properly managed
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Apache Kafka community best practices

## Integration Points

- **Companion Agent**: `@kafka-schema-registry-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Apache Kafka coverage |
<!-- Technology knowledge base entry for Kafka Schema Registry Specialist in Apache Kafka Others -->