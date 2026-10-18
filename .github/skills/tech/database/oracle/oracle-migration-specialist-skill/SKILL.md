---
description: "Oracle Migration Specialist skill -- Plans and executes Oracle migrations including version upgrades, platform migrations, and cloud transitions with minimal downtime"
---

# Oracle Migration Specialist Skill

**Category:** Tech Skills > Database > Oracle

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Oracle Migration Specialist operations using Oracle technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Oracle within Database development.

## When to Use

- When upgrading Oracle database versions
- When migrating Oracle to cloud platforms
- When converting from Oracle to other database platforms
- When Oracle-specific technical expertise is required
- When best practices for Oracle technology stack must be applied
- When production-grade Oracle implementation guidance is needed

## Capabilities

- Plan Oracle upgrades with pre-upgrade checks
- Use Oracle Data Pump for schema and data migration
- Implement GoldenGate for zero-downtime migration
- Handle character set and platform conversions
- Validate application compatibility post-migration

## Procedure

1. Run pre-upgrade utility for compatibility
2. Plan migration with appropriate tool selection
3. Execute migration with Data Pump or GoldenGate
4. Validate data integrity post-migration
5. Test application functionality
6. Document rollback procedures

## Output Format

Return structured results:

- **Migration Plan**
- **Pre-Upgrade Report**
- **Validation Results**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Oracle Upgrade** | Database upgrade procedures and best practices |
| **Data Pump** | Export/import utility for data migration |
| **GoldenGate** | Real-time data replication for migration |

## Anti-Hallucination Rules

- Do not skip pre-upgrade compatibility checks
- Verify Data Pump features in target Oracle version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Pre-upgrade checks pass without errors
- Data integrity verified post-migration
- Application functions correctly with new version
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Oracle community best practices

## Integration Points

- **Companion Agent**: `@oracle-migration-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Oracle coverage |
<!-- Technology knowledge base entry for Oracle Migration Specialist in Oracle Database -->