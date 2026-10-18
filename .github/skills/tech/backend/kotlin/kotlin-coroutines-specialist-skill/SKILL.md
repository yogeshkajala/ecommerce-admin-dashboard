---
description: "Kotlin Coroutines Specialist skill -- Implements asynchronous Kotlin applications with coroutines, flows, and structured concurrency for efficient concurrent operations"
---

# Kotlin Coroutines Specialist Skill

**Category:** Tech Skills > Backend > Kotlin

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Kotlin Coroutines Specialist operations using Kotlin technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Kotlin within Backend development.

## When to Use

- When building async Kotlin applications with coroutines
- When implementing reactive streams with Kotlin Flow
- When managing structured concurrency with coroutine scopes
- When Kotlin-specific technical expertise is required
- When best practices for Kotlin technology stack must be applied
- When production-grade Kotlin implementation guidance is needed

## Capabilities

- Build coroutines with proper scope management
- Implement Kotlin Flow for reactive data streams
- Design structured concurrency with supervisorScope
- Handle cancellation and exception propagation
- Test coroutines with kotlinx-coroutines-test

## Procedure

1. Analyze async requirements and scope boundaries
2. Design coroutine architecture with proper scoping
3. Implement coroutines with structured concurrency
4. Add Flow for reactive data processing
5. Handle cancellation and error propagation
6. Test with TestCoroutineDispatcher

## Output Format

Return structured results:

- **Coroutine Architecture**
- **Flow Design**
- **Error Handling**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Coroutines Guide** | Official coroutines patterns and best practices |
| **Structured Concurrency** | Scope-based lifecycle management |
| **Flow** | Cold asynchronous stream patterns |

## Anti-Hallucination Rules

- Do not launch coroutines in GlobalScope in production code
- Verify coroutine features in target Kotlin version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Coroutines use proper scoping
- Cancellation is handled at all levels
- Flow collectors handle backpressure
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Kotlin community best practices

## Integration Points

- **Companion Agent**: `@kotlin-coroutines-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Kotlin coverage |
<!-- Technology knowledge base entry for Kotlin Coroutines Specialist in Kotlin Backend -->