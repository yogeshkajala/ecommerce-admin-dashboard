---
description: "Java Microservices Architect skill -- Designs and implements Java microservice architectures with proper service boundaries, communication patterns, and resilience strategies"
---

# Java Microservices Architect Skill

**Category:** Tech Skills > Backend > Java

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Java Microservices Architect operations using Java technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Java within Backend development.

## When to Use

- When designing microservice boundaries from domain models
- When implementing inter-service communication with REST or gRPC
- When adding resilience patterns: circuit breaker, retry, bulkhead
- When Java-specific technical expertise is required
- When best practices for Java technology stack must be applied
- When production-grade Java implementation guidance is needed

## Capabilities

- Design service boundaries using DDD bounded contexts
- Implement REST and gRPC inter-service communication
- Add circuit breaker patterns with Resilience4j
- Configure service discovery with Eureka or Consul
- Design event-driven communication with Kafka or RabbitMQ

## Procedure

1. Analyze domain model for service boundaries
2. Design communication patterns and contracts
3. Implement service with Spring Boot microservice template
4. Add resilience patterns and fallbacks
5. Configure service discovery and load balancing
6. Test with contract tests and chaos engineering

## Output Format

Return structured results:

- **Service Architecture**
- **Communication Contracts**
- **Resilience Configuration**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Microservice Patterns** | Service decomposition and communication patterns |
| **Resilience4j** | Circuit breaker, retry, and bulkhead patterns |
| **Spring Cloud** | Spring Cloud microservice ecosystem |

## Anti-Hallucination Rules

- Do not assume service mesh features are available without verification
- Verify Spring Cloud version compatibility across services
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Service boundaries follow domain boundaries
- Resilience patterns handle all failure modes
- Service contracts are versioned and backward compatible
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Java community best practices

## Integration Points

- **Companion Agent**: `@java-microservices-architect` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Java coverage |