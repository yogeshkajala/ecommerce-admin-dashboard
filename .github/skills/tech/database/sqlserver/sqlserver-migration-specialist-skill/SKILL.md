---
description: "SQL Server Migration Specialist skill -- Plans and executes SQL Server migrations including version upgrades, cloud migration to Azure SQL, and cross-platform conversions"
---

# SQL Server Migration Specialist Skill

**Category:** Tech Skills > Database > SQL Server

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for SQL Server Migration Specialist operations using SQL Server technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for SQL Server within Database development.

## When to Use

- When upgrading SQL Server to new versions
- When migrating to Azure SQL Database or Managed Instance
- When converting from other RDBMS to SQL Server
- When SQL Server-specific technical expertise is required
- When best practices for SQL Server technology stack must be applied
- When production-grade SQL Server implementation guidance is needed

## Capabilities

- Plan version upgrades with compatibility assessment
- Migrate to Azure SQL with DMA and DMS
- Handle compatibility level and feature changes
- Convert schemas from other RDBMS platforms
- Validate application compatibility post-migration

## Procedure

1. Run Data Migration Assistant assessment
2. Fix compatibility issues before migration
3. Execute migration with minimal downtime
4. Validate data integrity and functionality
5. Update compatibility level post-migration
6. Document changes and rollback procedures

## Output Format

Return structured results:

- **Migration Plan**
- **Assessment Report**
- **Validation Results**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **DMA** | Data Migration Assistant for assessment |
| **Azure DMS** | Database Migration Service for Azure SQL |
| **Compatibility** | Compatibility level management and features |

## Anti-Hallucination Rules

- Do not skip compatibility assessment before migration
- Verify feature availability in target SQL Server edition
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Assessment identifies all blocking issues
- Migration completes with verified data integrity
- Application functions correctly post-migration
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow SQL Server community best practices

## Integration Points

- **Companion Agent**: `@sqlserver-migration-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full SQL Server coverage |
<!-- Technology knowledge base entry for SQL Server Migration Specialist in SQL Server Database -->