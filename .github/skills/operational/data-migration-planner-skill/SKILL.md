---
description: "Data Migration Planner skill -- Use when planning data migration including schema mapping, ETL design, data cleansing, and validation strategy."
---

# Data Migration Planner Skill

**Category:** Tech Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Data Migration Planner operations. This skill encapsulates technology-specific patterns, toolchain expertise, and implementation best practices.

## When to Use

- When planning data migration including schema mapping, ETL design, data cleansing, and validation strategy
- When technology-specific patterns and toolchain expertise are required
- When automated scanning, analysis, or code generation is needed
- When integration with development tools and CI/CD pipelines is required

## Capabilities

- Analyze query execution plans and optimize for performance
- Design database schemas following normalization and indexing best practices
- Configure backup strategies with recovery point and time objectives
- Manage data replication for high availability and disaster recovery
- Execute schema migrations with zero-downtime deployment patterns
- Monitor database health: connections, locks, buffer utilization, replication lag
- Validate data integrity through constraint checks and consistency verification
- Generate database reports with performance metrics and optimization recommendations

## Procedure

1. Receive database request -- identify target database, operation type, and constraints
2. Analyze current database state: schema, indexes, query patterns, and performance metrics
3. Design changes following normalization rules and data integrity constraints
4. Generate migration scripts with up/down reversibility
5. Execute changes in a transaction with validation checkpoints
6. Verify data integrity: referential integrity, constraint satisfaction, index coverage
7. Run performance tests on modified queries and compare against baseline
8. Document schema changes and update data dictionary
9. Generate database operation report with changes, performance impact, and recommendations

## Output Format

Return structured results:

- **Summary**: operation performed, scope, and execution status
- **Findings**: issue ID, severity, file/location, description, remediation
- **Metrics**: quantitative measurements (coverage, complexity, performance, counts)
- **Quality Gate**: PASS/FAIL with gate criteria evaluation details
- **Recommendations**: prioritized improvement actions with effort estimates

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **AWS 7R Migration** | Migration strategies: rehost, replatform, refactor, repurchase, retire, retain, relocate |
| **TOGAF ADM** | Architecture development method for transformation initiatives |
| **Strangler Fig Pattern** | Incremental migration pattern for legacy system replacement |

## Anti-Hallucination Rules

- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER report tool output without actual execution evidence
- ALWAYS verify version compatibility before applying technology-specific patterns

## Constraints

- NEVER execute destructive operations without explicit user confirmation
- NEVER store, log, or expose secrets, credentials, or PII in output
- ALWAYS provide evidence for assertions -- no claims without supporting data
- ALWAYS follow the principle of least privilege for tool and data access
- NEVER bypass security checks or disable safety validations
- ALWAYS use the appropriate tool version matching the target environment
