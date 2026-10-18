---
description: "Java Concurrency Specialist skill -- Implements thread-safe Java applications using concurrency utilities, virtual threads, and reactive patterns for high-performance systems"
---

# Java Concurrency Specialist Skill

**Category:** Tech Skills > Backend > Java

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Java Concurrency Specialist operations using Java technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Java within Backend development.

## When to Use

- When designing concurrent Java applications with thread safety
- When implementing virtual threads for scalable I/O operations
- When debugging race conditions and deadlock scenarios
- When Java-specific technical expertise is required
- When best practices for Java technology stack must be applied
- When production-grade Java implementation guidance is needed

## Capabilities

- Implement thread-safe patterns with java.util.concurrent
- Use virtual threads for scalable concurrent I/O
- Design lock-free algorithms with atomic operations
- Build reactive streams with Project Reactor or RxJava
- Debug concurrency issues with thread dumps and profilers

## Procedure

1. Analyze concurrency requirements and constraints
2. Choose appropriate concurrency model
3. Implement thread-safe code with proper synchronization
4. Add error handling for concurrent operations
5. Test with concurrent test frameworks
6. Profile for contention and performance

## Output Format

Return structured results:

- **Concurrency Design**
- **Thread Safety Analysis**
- **Performance Profile**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Java Concurrency in Practice** | Industry standard patterns for thread safety |
| **Virtual Threads** | Project Loom lightweight thread model |
| **Reactive Streams** | Non-blocking backpressure-aware stream processing |

## Anti-Hallucination Rules

- Do not assume virtual threads are available in Java versions before 21
- Verify concurrent utility availability in target Java version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Code is thread-safe under concurrent access
- No potential deadlocks or livelocks exist
- Performance scales with available cores
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Java community best practices

## Integration Points

- **Companion Agent**: `@java-concurrency-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Java coverage |