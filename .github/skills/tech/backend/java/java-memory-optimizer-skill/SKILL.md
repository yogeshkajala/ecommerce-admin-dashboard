---
description: "Java Memory Optimizer skill -- Analyzes and optimizes JVM memory usage through heap tuning, garbage collection configuration, and memory leak detection"
---

# Java Memory Optimizer Skill

**Category:** Tech Skills > Backend > Java

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Java Memory Optimizer operations using Java technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Java within Backend development.

## When to Use

- When tuning JVM heap size and garbage collector settings
- When diagnosing memory leaks with heap dumps
- When optimizing object allocation patterns for GC efficiency
- When Java-specific technical expertise is required
- When best practices for Java technology stack must be applied
- When production-grade Java implementation guidance is needed

## Capabilities

- Analyze heap dumps with Eclipse MAT or VisualVM
- Configure garbage collectors: G1, ZGC, Shenandoah
- Identify memory leaks with allocation tracking
- Optimize object allocation and pooling patterns
- Tune JVM flags for optimal memory performance

## Procedure

1. Baseline memory usage with JVM monitoring
2. Capture and analyze heap dumps
3. Identify memory leaks and retention paths
4. Configure appropriate garbage collector
5. Tune heap sizes and GC parameters
6. Validate improvements with load testing

## Output Format

Return structured results:

- **Memory Analysis Report**
- **GC Configuration**
- **Tuning Recommendations**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **JVM Tuning** | JVM memory management and GC tuning guidelines |
| **GC Algorithms** | G1, ZGC, Shenandoah selection criteria |
| **Memory Analysis** | Heap dump analysis and leak detection patterns |

## Anti-Hallucination Rules

- Do not assume GC algorithm availability across all JVM versions
- Verify JVM flags are valid for the target JVM vendor and version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Memory usage stays within defined limits
- GC pause times meet latency requirements
- No memory leaks detected under sustained load
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Java community best practices

## Integration Points

- **Companion Agent**: `@java-memory-optimizer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Java coverage |
<!-- Technology knowledge base entry for Java Memory Optimizer in Java Backend -->