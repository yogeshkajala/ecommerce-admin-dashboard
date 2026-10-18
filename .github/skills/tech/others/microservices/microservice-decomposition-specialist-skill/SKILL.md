---
description: "Microservice Decomposition Specialist skill -- Decomposes monolithic applications into microservices using domain-driven design with bounded contexts and service boundaries"
---

# Microservice Decomposition Specialist Skill

**Category:** Tech Skills > Others > Microservices

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Microservice Decomposition Specialist operations using Microservices technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Microservices within Others development.

## When to Use

- When decomposing monolithic applications into microservices
- When identifying service boundaries with bounded contexts
- When designing service communication patterns
- When Microservices-specific technical expertise is required
- When best practices for Microservices technology stack must be applied
- When production-grade Microservices implementation guidance is needed

## Capabilities

- Identify bounded contexts from domain model
- Define service boundaries and ownership
- Design service communication patterns
- Plan data decomposition per service
- Create migration strategy from monolith

## Procedure

1. Analyze domain model with event storming
2. Identify bounded contexts
3. Define service boundaries
4. Design inter-service communication
5. Plan data partitioning
6. Create incremental migration plan

## Output Format

Return structured results:

- **Service Design**
- **Context Map**
- **Migration Plan**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **DDD** | Domain-driven design for service boundaries |
| **Bounded Contexts** | Context mapping and boundaries |
| **Strangler Pattern** | Incremental monolith decomposition |

## Anti-Hallucination Rules

- Do not create microservices for every entity - group by bounded context
- Verify team capacity to own proposed services
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Services have clear ownership and boundaries
- Communication patterns are well-defined
- Migration plan is incremental and low-risk
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Microservices community best practices

## Integration Points

- **Companion Agent**: `@microservice-decomposition-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Microservices coverage |
<!-- Technology knowledge base entry for Microservice Decomposition Specialist in Microservices Others -->