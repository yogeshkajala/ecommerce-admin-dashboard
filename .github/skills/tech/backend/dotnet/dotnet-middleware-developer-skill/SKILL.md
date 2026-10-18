---
description: ".NET Middleware Developer skill -- Creates ASP.NET Core middleware for request processing including authentication, logging, error handling, and custom request pipeline stages"
---

# .NET Middleware Developer Skill

**Category:** Tech Skills > Backend > .NET

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for .NET Middleware Developer operations using .NET technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for .NET within Backend development.

## When to Use

- When building custom middleware for ASP.NET Core request pipeline
- When implementing cross-cutting concerns in middleware
- When configuring middleware ordering for proper request processing
- When .NET-specific technical expertise is required
- When best practices for .NET technology stack must be applied
- When production-grade .NET implementation guidance is needed

## Capabilities

- Build custom middleware with proper request/response handling
- Implement middleware with dependency injection
- Configure middleware ordering in the pipeline
- Create conditional middleware with MapWhen and UseWhen
- Build terminal middleware for specific routes

## Procedure

1. Identify cross-cutting concerns for middleware
2. Design middleware with single responsibility
3. Implement middleware with proper next() invocation
4. Configure middleware ordering
5. Add dependency injection for services
6. Test middleware in isolation and pipeline context

## Output Format

Return structured results:

- **Middleware Implementation**
- **Pipeline Configuration**
- **Error Handling**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **ASP.NET Middleware** | Official middleware pattern and conventions |
| **Request Pipeline** | Middleware ordering and short-circuiting |
| **Exception Handling** | Global exception handling middleware patterns |

## Anti-Hallucination Rules

- Do not skip calling next() unless intentionally short-circuiting
- Verify middleware compatibility with endpoint routing
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Middleware ordering follows logical request flow
- Error handling middleware catches all unhandled exceptions
- Middleware does not buffer entire response bodies unnecessarily
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow .NET community best practices

## Integration Points

- **Companion Agent**: `@dotnet-middleware-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full .NET coverage |