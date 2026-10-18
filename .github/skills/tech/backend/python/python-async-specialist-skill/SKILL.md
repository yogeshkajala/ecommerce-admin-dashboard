---
description: "Python Async Specialist skill -- Implements asynchronous Python applications with asyncio, aiohttp, and async generators for high-concurrency I/O operations"
---

# Python Async Specialist Skill

**Category:** Tech Skills > Backend > Python

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Python Async Specialist operations using Python technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Python within Backend development.

## When to Use

- When building high-concurrency applications with asyncio
- When implementing async HTTP clients with aiohttp
- When designing async generators for streaming data processing
- When Python-specific technical expertise is required
- When best practices for Python technology stack must be applied
- When production-grade Python implementation guidance is needed

## Capabilities

- Build asyncio event loops with proper lifecycle
- Implement async context managers and iterators
- Create async HTTP clients with connection pooling
- Design task groups and structured concurrency
- Handle cancellation and timeout patterns

## Procedure

1. Analyze concurrency requirements
2. Design async architecture with proper task management
3. Implement async functions with error handling
4. Configure connection pooling and limits
5. Test with pytest-asyncio
6. Profile event loop for blocking operations

## Output Format

Return structured results:

- **Async Architecture**
- **Task Management**
- **Performance Profile**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **asyncio Documentation** | Official asyncio patterns and best practices |
| **Structured Concurrency** | TaskGroup patterns for safe task management |
| **aiohttp** | Async HTTP client/server patterns |

## Anti-Hallucination Rules

- Do not block the event loop with synchronous I/O calls
- Verify async features match the target Python version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Event loop is not blocked by synchronous operations
- Tasks handle cancellation gracefully
- Connection pools have proper limits configured
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Python community best practices

## Integration Points

- **Companion Agent**: `@python-async-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Python coverage |
<!-- Technology knowledge base entry for Python Async Specialist in Python Backend -->