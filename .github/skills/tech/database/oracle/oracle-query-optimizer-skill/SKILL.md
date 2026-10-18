---
description: "Oracle Query Optimizer skill -- Analyzes and optimizes Oracle queries using execution plans, hints, and optimizer statistics for maximum database performance"
---

# Oracle Query Optimizer Skill

**Category:** Tech Skills > Database > Oracle

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Oracle Query Optimizer operations using Oracle technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Oracle within Database development.

## When to Use

- When optimizing slow Oracle queries with EXPLAIN PLAN
- When managing optimizer statistics for accurate plans
- When using SQL Plan Baselines for plan stability
- When Oracle-specific technical expertise is required
- When best practices for Oracle technology stack must be applied
- When production-grade Oracle implementation guidance is needed

## Capabilities

- Analyze execution plans with DBMS_XPLAN
- Manage optimizer statistics with DBMS_STATS
- Use SQL Plan Baselines for plan stability
- Apply optimizer hints for plan control
- Configure automatic SQL tuning advisor

## Procedure

1. Identify slow queries with AWR reports
2. Analyze execution plans with DBMS_XPLAN
3. Verify optimizer statistics accuracy
4. Create SQL Plan Baselines for stable plans
5. Apply SQL profiles from tuning advisor
6. Benchmark improvements with SQL Performance Analyzer

## Output Format

Return structured results:

- **Query Analysis**
- **Statistics Management**
- **Plan Baselines**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Oracle Optimizer** | Cost-based optimizer configuration and statistics |
| **AWR** | Automatic Workload Repository for diagnostics |
| **SQL Plan Baselines** | Plan stability management |

## Anti-Hallucination Rules

- Do not ignore optimizer statistics staleness
- Verify optimizer features in target Oracle version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Plans are stable with SQL Plan Baselines
- Statistics are fresh and representative
- AWR reports show improvement trends
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Oracle community best practices

## Integration Points

- **Companion Agent**: `@oracle-query-optimizer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Oracle coverage |
<!-- Technology knowledge base entry for Oracle Query Optimizer in Oracle Database -->
<!-- Technology knowledge base entry for Oracle Query Optimizer in Oracle Database -->