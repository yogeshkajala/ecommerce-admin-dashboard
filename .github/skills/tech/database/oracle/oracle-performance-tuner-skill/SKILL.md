---
description: "Oracle Performance Tuner skill -- Tunes Oracle database performance through SGA/PGA configuration, optimizer settings, and AWR-based diagnostics for production workloads"
---

# Oracle Performance Tuner Skill

**Category:** Tech Skills > Database > Oracle

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Oracle Performance Tuner operations using Oracle technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Oracle within Database development.

## When to Use

- When tuning Oracle SGA and PGA memory settings
- When analyzing AWR reports for performance bottlenecks
- When configuring automatic memory management
- When Oracle-specific technical expertise is required
- When best practices for Oracle technology stack must be applied
- When production-grade Oracle implementation guidance is needed

## Capabilities

- Configure SGA and PGA for optimal memory usage
- Analyze AWR and ADDM reports for recommendations
- Tune buffer cache and shared pool sizes
- Configure automatic memory management
- Monitor with Enterprise Manager and custom scripts

## Procedure

1. Capture baseline with AWR snapshots
2. Run ADDM for automatic diagnostic recommendations
3. Configure memory management settings
4. Tune buffer cache hit ratio
5. Optimize redo log and undo settings
6. Validate improvements with SQL Performance Analyzer

## Output Format

Return structured results:

- **Performance Analysis**
- **Configuration Changes**
- **Improvement Metrics**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **AWR** | Automatic Workload Repository for diagnostics |
| **ADDM** | Automatic Database Diagnostic Monitor |
| **Memory Management** | SGA, PGA, and AMM configuration |

## Anti-Hallucination Rules

- Do not set SGA larger than available physical memory
- Verify memory management features in target Oracle version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Buffer cache hit ratio exceeds 95%
- PGA in-memory sorts exceed 95%
- ADDM recommendations are addressed
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Oracle community best practices

## Integration Points

- **Companion Agent**: `@oracle-performance-tuner` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Oracle coverage |
<!-- Technology knowledge base entry for Oracle Performance Tuner in Oracle Database -->
<!-- Technology knowledge base entry for Oracle Performance Tuner in Oracle Database -->