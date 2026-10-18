---
description: ".NET Entity Framework Specialist skill -- Implements data access layers with Entity Framework Core including migrations, query optimization, and advanced mapping configurations"
---

# .NET Entity Framework Specialist Skill

**Category:** Tech Skills > Backend > .NET

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for .NET Entity Framework Specialist operations using .NET technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for .NET within Backend development.

## When to Use

- When designing EF Core data models with proper relationships
- When optimizing EF Core queries and preventing N+1 problems
- When managing database migrations and schema evolution
- When .NET-specific technical expertise is required
- When best practices for .NET technology stack must be applied
- When production-grade .NET implementation guidance is needed

## Capabilities

- Design entity configurations with Fluent API
- Optimize queries with split queries and compiled queries
- Manage migrations with proper versioning strategy
- Implement value objects and owned types
- Configure database interceptors for cross-cutting concerns

## Procedure

1. Analyze domain model for EF Core mapping
2. Configure entity relationships with Fluent API
3. Implement repository pattern if appropriate
4. Optimize queries with profiling
5. Set up migration strategy
6. Test with in-memory or container database

## Output Format

Return structured results:

- **Entity Configuration**
- **Query Optimization Plan**
- **Migration Strategy**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **EF Core Documentation** | Official Entity Framework Core patterns |
| **EF Core Performance** | Query optimization and tracking behavior |
| **Migration Strategy** | Database migration best practices |

## Anti-Hallucination Rules

- Do not assume EF Core features exist in all versions
- Verify provider-specific features for target database
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- No N+1 queries exist in critical paths
- Migrations are idempotent and reversible
- Change tracking is configured appropriately
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow .NET community best practices

## Integration Points

- **Companion Agent**: `@dotnet-entity-framework-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full .NET coverage |