---
description: "Go Concurrency Specialist skill -- Implements concurrent Go applications using goroutines, channels, select statements, and sync primitives for safe parallel execution"
---

# Go Concurrency Specialist Skill

**Category:** Tech Skills > Backend > Go

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Go Concurrency Specialist operations using Go technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Go within Backend development.

## When to Use

- When designing concurrent Go applications with goroutines
- When implementing fan-out/fan-in patterns with channels
- When preventing race conditions with sync primitives
- When Go-specific technical expertise is required
- When best practices for Go technology stack must be applied
- When production-grade Go implementation guidance is needed

## Capabilities

- Design goroutine patterns with proper lifecycle management
- Implement channel-based communication patterns
- Use sync.WaitGroup, Mutex, and atomic operations
- Build fan-out/fan-in and pipeline patterns
- Detect race conditions with -race flag

## Procedure

1. Analyze concurrency requirements
2. Design goroutine and channel architecture
3. Implement concurrent patterns with proper synchronization
4. Add context-based cancellation
5. Test with race detector enabled
6. Profile goroutine counts and memory usage

## Output Format

Return structured results:

- **Concurrency Design**
- **Channel Architecture**
- **Race Analysis**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Go Concurrency Patterns** | Official goroutine and channel patterns |
| **Race Detector** | Built-in race condition detection tool |
| **Context Package** | Cancellation and timeout propagation |

## Anti-Hallucination Rules

- Do not assume goroutines are free - monitor goroutine leaks
- Verify context package usage in target Go version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- No data races detected with race detector
- Goroutines are properly cleaned up on shutdown
- Channels are properly closed to prevent leaks
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Go community best practices

## Integration Points

- **Companion Agent**: `@go-concurrency-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Go coverage |
<!-- Technology knowledge base entry for Go Concurrency Specialist in Go Backend -->