---
description: "Go Performance Optimizer skill -- Profiles and optimizes Go application performance through pprof analysis, memory allocation reduction, and runtime tuning"
---

# Go Performance Optimizer Skill

**Category:** Tech Skills > Backend > Go

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Go Performance Optimizer operations using Go technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Go within Backend development.

## When to Use

- When profiling Go applications with pprof
- When reducing memory allocations and GC pressure
- When optimizing hot paths with benchmarks
- When Go-specific technical expertise is required
- When best practices for Go technology stack must be applied
- When production-grade Go implementation guidance is needed

## Capabilities

- Profile CPU and memory with pprof
- Write benchmarks with testing.B
- Reduce allocations with sync.Pool and buffer reuse
- Optimize with escape analysis awareness
- Tune GOMAXPROCS and GC settings

## Procedure

1. Baseline performance with benchmarks
2. Profile CPU usage with pprof
3. Analyze memory allocations and GC pressure
4. Optimize hot paths based on profile data
5. Re-benchmark to validate improvements
6. Document optimization trade-offs

## Output Format

Return structured results:

- **Profile Analysis**
- **Benchmark Results**
- **Optimization Plan**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **pprof** | Go profiling tool for CPU and memory analysis |
| **Benchmarks** | Writing and interpreting Go benchmarks |
| **GC Tuning** | GOGC and memory limit configuration |

## Anti-Hallucination Rules

- Do not optimize without profiling data
- Verify pprof features in target Go version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Optimizations are backed by benchmark data
- Allocations are reduced in hot paths
- GC settings match workload characteristics
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Go community best practices

## Integration Points

- **Companion Agent**: `@go-performance-optimizer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Go coverage |
<!-- Technology knowledge base entry for Go Performance Optimizer in Go Backend -->
<!-- Technology knowledge base entry for Go Performance Optimizer in Go Backend -->
<!-- Technology knowledge base entry for Go Performance Optimizer in Go Backend -->