---
description: "SQL Server Performance Tuner skill -- Tunes SQL Server configuration including memory, tempdb, MAXDOP, and resource governor for optimal workload performance"
---

# SQL Server Performance Tuner Skill

**Category:** Tech Skills > Database > SQL Server

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for SQL Server Performance Tuner operations using SQL Server technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for SQL Server within Database development.

## When to Use

- When tuning SQL Server memory and CPU configuration
- When optimizing tempdb for concurrent workloads
- When configuring Resource Governor for workload management
- When SQL Server-specific technical expertise is required
- When best practices for SQL Server technology stack must be applied
- When production-grade SQL Server implementation guidance is needed

## Capabilities

- Configure max server memory and min server memory
- Optimize tempdb file count and sizing
- Set MAXDOP and cost threshold for parallelism
- Configure Resource Governor for workload isolation
- Monitor with Extended Events and DMVs

## Procedure

1. Baseline current performance metrics
2. Configure memory settings based on workload
3. Optimize tempdb with proper file configuration
4. Set parallelism thresholds
5. Configure Resource Governor if multi-workload
6. Validate improvements with monitoring

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
| **SQL Server Tuning** | Server configuration best practices |
| **tempdb** | tempdb optimization guidelines |
| **Resource Governor** | Workload isolation and management |

## Anti-Hallucination Rules

- Do not set max memory to total available RAM
- Verify configuration settings exist in target SQL Server version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Memory pressure indicators are healthy
- tempdb contention is eliminated
- MAXDOP setting matches hardware topology
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow SQL Server community best practices

## Integration Points

- **Companion Agent**: `@sqlserver-performance-tuner` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full SQL Server coverage |
<!-- Technology knowledge base entry for SQL Server Performance Tuner in SQL Server Database -->