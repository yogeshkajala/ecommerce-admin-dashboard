---
description: "MongoDB Migration Specialist skill -- Plans and executes MongoDB migrations including version upgrades, schema migrations, and data platform transitions"
---

# MongoDB Migration Specialist Skill

**Category:** Tech Skills > Database > MongoDB

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for MongoDB Migration Specialist operations using MongoDB technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for MongoDB within Database development.

## When to Use

- When upgrading MongoDB major versions
- When migrating from self-hosted to MongoDB Atlas
- When executing schema migrations in production
- When MongoDB-specific technical expertise is required
- When best practices for MongoDB technology stack must be applied
- When production-grade MongoDB implementation guidance is needed

## Capabilities

- Plan MongoDB version upgrades with compatibility checks
- Migrate to MongoDB Atlas with mongomirror
- Execute schema migrations with data transformation
- Handle index rebuilds during upgrades
- Validate application compatibility post-migration

## Procedure

1. Assess migration complexity and compatibility
2. Test upgrade on staging environment
3. Execute migration with minimal downtime
4. Validate data integrity and application behavior
5. Update indexes and configurations
6. Document changes and rollback procedures

## Output Format

Return structured results:

- **Migration Plan**
- **Compatibility Report**
- **Validation Results**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **MongoDB Upgrade** | Version upgrade procedures and compatibility |
| **Atlas Migration** | Migration tools for Atlas deployment |
| **Schema Migration** | Patterns for evolving document schemas |

## Anti-Hallucination Rules

- Do not skip version upgrades - upgrade sequentially
- Verify driver compatibility with target MongoDB version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Data integrity verified post-migration
- Application queries return correct results
- Performance meets baseline expectations
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow MongoDB community best practices

## Integration Points

- **Companion Agent**: `@mongodb-migration-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full MongoDB coverage |
<!-- Technology knowledge base entry for MongoDB Migration Specialist in MongoDB Database -->