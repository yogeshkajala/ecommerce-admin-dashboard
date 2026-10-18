---
description: "Rust Performance Optimizer skill -- Profiles and optimizes Rust application performance through benchmarking, SIMD optimization, and zero-copy data processing"
---

# Rust Performance Optimizer Skill

**Category:** Tech Skills > Backend > Rust

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Rust Performance Optimizer operations using Rust technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Rust within Backend development.

## When to Use

- When profiling Rust applications for performance bottlenecks
- When implementing SIMD optimizations for data processing
- When reducing memory allocations with zero-copy patterns
- When Rust-specific technical expertise is required
- When best practices for Rust technology stack must be applied
- When production-grade Rust implementation guidance is needed

## Capabilities

- Profile with cargo-flamegraph and perf
- Write benchmarks with criterion.rs
- Implement SIMD operations with std::simd
- Design zero-copy parsers with nom or winnow
- Optimize with compile-time evaluation and const fn

## Procedure

1. Baseline with criterion benchmarks
2. Profile CPU with flamegraph
3. Identify allocation hotspots
4. Apply optimizations: SIMD, zero-copy, const fn
5. Re-benchmark to validate improvements
6. Document optimization trade-offs

## Output Format

Return structured results:

- **Benchmark Results**
- **Profile Analysis**
- **Optimization Plan**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **criterion.rs** | Statistical benchmarking framework |
| **Flamegraph** | CPU profiling visualization |
| **SIMD** | Portable SIMD operations in Rust |

## Anti-Hallucination Rules

- Do not optimize without benchmark data
- Verify SIMD features in target Rust edition
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Optimizations are validated with benchmarks
- SIMD code has scalar fallbacks
- Zero-copy patterns maintain safety guarantees
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Rust community best practices

## Integration Points

- **Companion Agent**: `@rust-performance-optimizer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Rust coverage |
<!-- Technology knowledge base entry for Rust Performance Optimizer in Rust Backend -->
<!-- Technology knowledge base entry for Rust Performance Optimizer in Rust Backend -->
<!-- Technology knowledge base entry for Rust Performance Optimizer in Rust Backend -->