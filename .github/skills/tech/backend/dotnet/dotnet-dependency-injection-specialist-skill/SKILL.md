---
description: ".NET DI Specialist skill -- Configures dependency injection in ASP.NET Core with proper lifetimes, factory patterns, and service registration for maintainable applications"
---

# .NET DI Specialist Skill

**Category:** Tech Skills > Backend > .NET

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for .NET DI Specialist operations using .NET technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for .NET within Backend development.

## When to Use

- When configuring dependency injection in ASP.NET Core applications
- When resolving service lifetime and captive dependency issues
- When implementing factory patterns for conditional service resolution
- When .NET-specific technical expertise is required
- When best practices for .NET technology stack must be applied
- When production-grade .NET implementation guidance is needed

## Capabilities

- Configure service registration with proper lifetimes
- Implement factory patterns for complex dependencies
- Resolve captive dependency and scope issues
- Build decorator and composite patterns with DI
- Configure keyed services and named instances

## Procedure

1. Analyze dependency graph for the application
2. Register services with appropriate lifetimes
3. Resolve captive dependency warnings
4. Implement factory patterns where needed
5. Test service resolution and lifetimes
6. Validate no memory leaks from improper scoping

## Output Format

Return structured results:

- **DI Configuration**
- **Lifetime Analysis**
- **Dependency Graph**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **DI Guidelines** | ASP.NET Core dependency injection best practices |
| **Service Lifetimes** | Transient, scoped, singleton selection criteria |
| **Captive Dependencies** | Avoiding scope misalignment issues |

## Anti-Hallucination Rules

- Do not register scoped services as singleton dependencies
- Verify keyed services availability in target .NET version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Service lifetimes are appropriate for usage patterns
- No captive dependency issues exist
- Factory patterns are used only when necessary
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow .NET community best practices

## Integration Points

- **Companion Agent**: `@dotnet-dependency-injection-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full .NET coverage |