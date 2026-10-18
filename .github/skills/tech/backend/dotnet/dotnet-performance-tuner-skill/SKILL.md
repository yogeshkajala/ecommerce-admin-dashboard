---
description: ".NET Performance Tuner skill -- Profiles and optimizes .NET application performance through memory analysis, async optimization, and runtime configuration tuning"
---

# .NET Performance Tuner Skill

**Category:** Tech Skills > Backend > .NET

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for .NET Performance Tuner operations using .NET technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for .NET within Backend development.

## When to Use

- When profiling .NET application CPU and memory usage
- When optimizing async/await patterns for throughput
- When tuning .NET runtime settings for production workloads
- When .NET-specific technical expertise is required
- When best practices for .NET technology stack must be applied
- When production-grade .NET implementation guidance is needed

## Capabilities

- Profile applications with dotnet-trace and dotnet-counters
- Analyze memory with dotnet-dump and PerfView
- Optimize async/await for reduced allocations
- Configure thread pool and GC for workload type
- Implement Span and Memory for zero-copy operations

## Procedure

1. Baseline performance with benchmark and profiling tools
2. Identify CPU hotspots with trace analysis
3. Analyze memory allocation patterns
4. Optimize async operations and allocations
5. Configure runtime settings for workload
6. Validate improvements with benchmarks

## Output Format

Return structured results:

- **Performance Profile**
- **Optimization Plan**
- **Benchmark Results**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **BenchmarkDotNet** | Microbenchmark framework for .NET |
| **.NET Performance** | Official performance best practices |
| **GC Tuning** | Garbage collection configuration guidelines |

## Anti-Hallucination Rules

- Do not fabricate performance numbers without actual profiling
- Verify diagnostic tool availability in target .NET version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Optimizations are backed by profiling data
- Async patterns reduce thread pool pressure
- GC configuration matches workload characteristics
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow .NET community best practices

## Integration Points

- **Companion Agent**: `@dotnet-performance-tuner` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full .NET coverage |
<!-- Technology knowledge base entry for .NET Performance Tuner in .NET Backend -->