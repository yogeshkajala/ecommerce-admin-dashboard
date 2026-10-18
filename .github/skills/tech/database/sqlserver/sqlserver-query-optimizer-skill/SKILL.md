---
description: "SQL Server Query Optimizer skill -- Analyzes and optimizes SQL Server queries using execution plans, index tuning, and query store for maximum performance"
---

# SQL Server Query Optimizer Skill

**Category:** Tech Skills > Database > SQL Server

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for SQL Server Query Optimizer operations using SQL Server technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for SQL Server within Database development.

## When to Use

- When optimizing slow SQL Server queries with execution plans
- When using Query Store for performance regression detection
- When tuning indexes with Database Engine Tuning Advisor
- When SQL Server-specific technical expertise is required
- When best practices for SQL Server technology stack must be applied
- When production-grade SQL Server implementation guidance is needed

## Capabilities

- Analyze execution plans with actual statistics
- Use Query Store for plan regression detection
- Design indexes with included columns
- Optimize parameter sniffing issues
- Configure compatibility level for optimizer features

## Procedure

1. Enable and configure Query Store
2. Identify regressed queries from Query Store
3. Analyze actual execution plans
4. Design missing indexes from plan recommendations
5. Force optimal plans when needed
6. Benchmark improvements with workload replay

## Output Format

Return structured results:

- **Query Analysis**
- **Index Recommendations**
- **Plan Management**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Query Store** | Performance monitoring and plan management |
| **Execution Plans** | Query plan analysis methodology |
| **Parameter Sniffing** | Handling plan sensitivity to parameters |

## Anti-Hallucination Rules

- Do not force plans without understanding query variations
- Verify Query Store features in target SQL Server version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Regressed queries are identified and fixed
- Index recommendations reduce I/O operations
- Parameter sniffing issues are resolved
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow SQL Server community best practices

## Integration Points

- **Companion Agent**: `@sqlserver-query-optimizer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full SQL Server coverage |
<!-- Technology knowledge base entry for SQL Server Query Optimizer in SQL Server Database -->