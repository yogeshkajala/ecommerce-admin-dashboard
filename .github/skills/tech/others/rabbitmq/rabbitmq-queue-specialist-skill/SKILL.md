---
description: "RabbitMQ Queue Specialist skill -- Configures RabbitMQ queues with proper durability, TTL, dead letter handling, and consumer management for reliable messaging"
---

# RabbitMQ Queue Specialist Skill

**Category:** Tech Skills > Others > RabbitMQ

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for RabbitMQ Queue Specialist operations using RabbitMQ technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for RabbitMQ within Others development.

## When to Use

- When configuring RabbitMQ queues for production workloads
- When implementing dead letter queues for error handling
- When managing consumer prefetch and acknowledgement
- When RabbitMQ-specific technical expertise is required
- When best practices for RabbitMQ technology stack must be applied
- When production-grade RabbitMQ implementation guidance is needed

## Capabilities

- Configure durable queues with proper properties
- Implement dead letter exchanges and queues
- Set TTL and max-length for queue management
- Configure consumer prefetch for flow control
- Implement priority queues for message ordering

## Procedure

1. Design queue topology for services
2. Configure queue durability and properties
3. Set up dead letter exchange routing
4. Configure TTL and length limits
5. Implement consumer acknowledgement patterns
6. Monitor queue depth and consumer lag

## Output Format

Return structured results:

- **Queue Configuration**
- **DLX Setup**
- **Consumer Settings**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Queue Configuration** | Queue properties and durability settings |
| **Dead Letters** | DLX configuration and retry patterns |
| **Consumer** | Prefetch and acknowledgement patterns |

## Anti-Hallucination Rules

- Do not auto-acknowledge messages in production without understanding implications
- Verify queue features in RabbitMQ version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Queues are durable for important messages
- Dead letters capture failed messages
- Prefetch prevents consumer overload
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow RabbitMQ community best practices

## Integration Points

- **Companion Agent**: `@rabbitmq-queue-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full RabbitMQ coverage |
<!-- Technology knowledge base entry for RabbitMQ Queue Specialist in RabbitMQ Others -->