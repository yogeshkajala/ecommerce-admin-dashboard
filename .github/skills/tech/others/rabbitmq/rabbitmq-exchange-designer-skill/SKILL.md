---
description: "RabbitMQ Exchange Designer skill -- Designs RabbitMQ exchange topologies with direct, topic, fanout, and headers exchanges for flexible message routing"
---

# RabbitMQ Exchange Designer Skill

**Category:** Tech Skills > Others > RabbitMQ

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for RabbitMQ Exchange Designer operations using RabbitMQ technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for RabbitMQ within Others development.

## When to Use

- When designing message routing with RabbitMQ exchanges
- When implementing topic-based message filtering
- When creating exchange topologies for microservices
- When RabbitMQ-specific technical expertise is required
- When best practices for RabbitMQ technology stack must be applied
- When production-grade RabbitMQ implementation guidance is needed

## Capabilities

- Design exchange topologies for routing needs
- Implement topic exchanges with routing patterns
- Configure fanout exchanges for broadcasting
- Build headers exchanges for attribute routing
- Implement exchange-to-exchange bindings

## Procedure

1. Analyze message routing requirements
2. Choose exchange types per use case
3. Design binding patterns for routing
4. Configure exchange durability and properties
5. Test routing with different message types
6. Document exchange topology

## Output Format

Return structured results:

- **Exchange Topology**
- **Binding Configuration**
- **Routing Documentation**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **AMQP Exchanges** | Exchange types and routing patterns |
| **Topic Patterns** | Topic exchange routing key patterns |
| **Exchange Design** | Exchange topology best practices |

## Anti-Hallucination Rules

- Do not create excessive exchange-to-exchange bindings
- Verify exchange features in RabbitMQ version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Messages route to correct queues
- Exchange topology is documented
- Dead letter routing is configured
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow RabbitMQ community best practices

## Integration Points

- **Companion Agent**: `@rabbitmq-exchange-designer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full RabbitMQ coverage |
<!-- Technology knowledge base entry for RabbitMQ Exchange Designer in RabbitMQ Others -->
<!-- Technology knowledge base entry for RabbitMQ Exchange Designer in RabbitMQ Others -->