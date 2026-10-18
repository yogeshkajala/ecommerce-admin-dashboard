---
description: "Microservice Data Specialist skill -- Manages data in microservice architectures with database-per-service pattern, event sourcing, and CQRS for data consistency"
---

# Microservice Data Specialist Skill

**Category:** Tech Skills > Others > Microservices

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Microservice Data Specialist operations using Microservices technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Microservices within Others development.

## When to Use

- When implementing database-per-service pattern
- When designing event sourcing for audit and replay
- When implementing CQRS for read/write optimization
- When Microservices-specific technical expertise is required
- When best practices for Microservices technology stack must be applied
- When production-grade Microservices implementation guidance is needed

## Capabilities

- Implement database-per-service pattern
- Design event sourcing for state management
- Build CQRS for separated read/write models
- Implement eventual consistency patterns
- Handle data queries across services

## Procedure

1. Design data ownership per service
2. Implement data storage per service
3. Add event sourcing if needed
4. Build CQRS projections for reads
5. Implement cross-service queries
6. Handle eventual consistency

## Output Format

Return structured results:

- **Data Architecture**
- **Event Store Design**
- **CQRS Projections**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Database per Service** | Data isolation pattern for microservices |
| **Event Sourcing** | Event-based state management |
| **CQRS** | Command Query Responsibility Segregation |

## Anti-Hallucination Rules

- Do not share databases between services
- Verify event store supports required throughput
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Each service owns its data
- Event sourcing captures all state changes
- CQRS projections are eventually consistent
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Microservices community best practices

## Integration Points

- **Companion Agent**: `@microservice-data-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Microservices coverage |
<!-- Technology knowledge base entry for Microservice Data Specialist in Microservices Others -->
<!-- Technology knowledge base entry for Microservice Data Specialist in Microservices Others -->