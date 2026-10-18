---
description: "Kotlin DSL Builder skill -- Creates type-safe domain-specific languages in Kotlin using builder patterns, extension functions, and receiver types"
---

# Kotlin DSL Builder Skill

**Category:** Tech Skills > Backend > Kotlin

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Kotlin DSL Builder operations using Kotlin technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Kotlin within Backend development.

## When to Use

- When building type-safe builder DSLs for configuration
- When creating fluent APIs with Kotlin extension functions
- When designing HTML or SQL-like DSLs with receiver types
- When Kotlin-specific technical expertise is required
- When best practices for Kotlin technology stack must be applied
- When production-grade Kotlin implementation guidance is needed

## Capabilities

- Build type-safe builders with @DslMarker
- Create fluent APIs with extension functions
- Implement receiver-type DSLs for nested structures
- Design scope-control with DslMarker annotations
- Add operator overloading for natural syntax

## Procedure

1. Identify domain concepts for DSL design
2. Design DSL syntax with user ergonomics in mind
3. Implement builders with proper scope control
4. Add type safety with DslMarker and generics
5. Test DSL output against expected structures
6. Document DSL usage with examples

## Output Format

Return structured results:

- **DSL Implementation**
- **API Documentation**
- **Usage Examples**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Kotlin DSL** | Type-safe builder pattern documentation |
| **DslMarker** | Scope control annotation for nested DSLs |
| **Extension Functions** | Fluent API design with extensions |

## Anti-Hallucination Rules

- Do not create DSLs that sacrifice type safety for brevity
- Verify Kotlin features used are available in target version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- DSL prevents invalid constructions at compile time
- DslMarker prevents scope leaking
- DSL syntax is intuitive and well-documented
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Kotlin community best practices

## Integration Points

- **Companion Agent**: `@kotlin-dsl-builder` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Kotlin coverage |
<!-- Technology knowledge base entry for Kotlin DSL Builder in Kotlin Backend -->