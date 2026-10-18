---
description: "MySQL Performance Tuner skill -- Tunes MySQL server configuration including InnoDB settings, connection pool, and memory allocation for optimal workload performance"
---

# MySQL Performance Tuner Skill

**Category:** Tech Skills > Database > MySQL

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for MySQL Performance Tuner operations using MySQL technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for MySQL within Database development.

## When to Use

- When tuning MySQL server for production workloads
- When optimizing InnoDB buffer pool and log configuration
- When configuring connection pool and thread management
- When MySQL-specific technical expertise is required
- When best practices for MySQL technology stack must be applied
- When production-grade MySQL implementation guidance is needed

## Capabilities

- Tune InnoDB buffer pool size and instances
- Configure redo log size and flushing strategy
- Optimize connection pool and thread cache
- Set up Performance Schema for monitoring
- Configure query cache and optimizer settings

## Procedure

1. Baseline current performance metrics
2. Analyze workload characteristics
3. Tune InnoDB buffer pool and redo log
4. Configure connection and thread settings
5. Enable and configure Performance Schema
6. Benchmark improvements and validate

## Output Format

Return structured results:

- **Configuration Changes**
- **Performance Comparison**
- **Monitoring Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **InnoDB Tuning** | Buffer pool, redo log, and flush configuration |
| **Connection Management** | Thread pool and connection limit settings |
| **Performance Schema** | Server monitoring and diagnostics framework |

## Anti-Hallucination Rules

- Do not set buffer pool larger than available RAM
- Verify configuration parameters exist in target MySQL version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Performance improvements are measurable
- Server is stable under production load
- Monitoring covers all critical metrics
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow MySQL community best practices

## Integration Points

- **Companion Agent**: `@mysql-performance-tuner` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full MySQL coverage |
<!-- Technology knowledge base entry for MySQL Performance Tuner in MySQL Database -->