---
description: "Microservice Communication Specialist skill -- Implements inter-service communication patterns including synchronous REST/gRPC and asynchronous messaging with proper resilience"
---

# Microservice Communication Specialist Skill

**Category:** Tech Skills > Others > Microservices

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Microservice Communication Specialist operations using Microservices technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Microservices within Others development.

## When to Use

- When designing inter-service communication patterns
- When implementing synchronous and asynchronous communication
- When adding resilience with circuit breakers and retries
- When Microservices-specific technical expertise is required
- When best practices for Microservices technology stack must be applied
- When production-grade Microservices implementation guidance is needed

## Capabilities

- Implement sync communication with REST or gRPC
- Design async communication with message queues
- Add circuit breakers with resilience4j or Polly
- Implement retry with exponential backoff
- Design saga patterns for distributed transactions

## Procedure

1. Analyze communication requirements
2. Choose sync or async per interaction
3. Implement resilience patterns
4. Add circuit breakers and retries
5. Design compensating transactions if needed
6. Test failure scenarios thoroughly

## Output Format

Return structured results:

- **Communication Design**
- **Resilience Configuration**
- **Saga Definitions**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Communication Patterns** | Sync vs async communication selection |
| **Circuit Breaker** | Resilience pattern for cascading failure prevention |
| **Saga Pattern** | Distributed transaction management |

## Anti-Hallucination Rules

- Do not use synchronous communication for operations that can be async
- Verify resilience library compatibility with framework
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Communication handles failures gracefully
- Circuit breakers prevent cascading failures
- Sagas maintain data consistency
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Microservices community best practices

## Integration Points

- **Companion Agent**: `@microservice-communication-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Microservices coverage |