---
description: "Rust Async Developer skill -- Builds asynchronous Rust applications with Tokio or async-std including futures, task spawning, and async trait implementations"
---

# Rust Async Developer Skill

**Category:** Tech Skills > Backend > Rust

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Rust Async Developer operations using Rust technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Rust within Backend development.

## When to Use

- When building async applications with Tokio runtime
- When implementing async traits and futures
- When designing concurrent task architectures
- When Rust-specific technical expertise is required
- When best practices for Rust technology stack must be applied
- When production-grade Rust implementation guidance is needed

## Capabilities

- Build async applications with Tokio runtime
- Implement async trait methods
- Design task spawning and cancellation patterns
- Handle async streams with tokio::sync channels
- Build timeout and retry patterns with tokio::time

## Procedure

1. Choose async runtime and configure
2. Design async architecture with proper task management
3. Implement async functions with error handling
4. Add cancellation and timeout handling
5. Test async code with tokio::test
6. Profile for task and wake-up overhead

## Output Format

Return structured results:

- **Async Architecture**
- **Task Management**
- **Runtime Configuration**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Tokio** | Tokio runtime patterns and best practices |
| **Async Traits** | Async function in trait implementations |
| **Futures** | Future combinators and pinning |

## Anti-Hallucination Rules

- Do not block the async runtime with synchronous operations
- Verify async trait support in target Rust edition
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Tasks are properly cancelled on shutdown
- No blocking operations in async context
- Error handling covers all failure modes
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Rust community best practices

## Integration Points

- **Companion Agent**: `@rust-async-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Rust coverage |
<!-- Technology knowledge base entry for Rust Async Developer in Rust Backend -->
<!-- Technology knowledge base entry for Rust Async Developer in Rust Backend -->