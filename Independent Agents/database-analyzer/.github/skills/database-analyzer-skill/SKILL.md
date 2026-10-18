---
description: "Database Analyzer skill -- Analyze shared database: table ownership, cross-domain joins, write patterns."
---
# Database Analyzer Skill

## Purpose
Provides domain-specific knowledge and step-by-step procedures for Database Analyzer operations.

## When to Use
- When performing database tasks that require specialized knowledge
- When structured output and validated results are needed
- When domain best practices and industry standards must be applied

## Capabilities
- Analyze query performance using execution plans and index utilization metrics
- Design database schemas following normalization and denormalization best practices
- Plan and execute database migrations with zero-downtime strategies
- Monitor database health including connection pools, replication lag, and lock contention
- Optimize slow queries through index recommendations and query rewriting
- Validate backup and recovery procedures with point-in-time restore testing
- Assess database security including encryption, access controls, and audit logging
- Generate database health reports with capacity projections and performance trends

## Procedure
1. Receive database request -- identify operation type, target database, and constraints
2. Assess current state -- review schema, indexes, query patterns, and performance baselines
3. Analyze performance -- examine slow queries, missing indexes, and lock contention
4. Design optimization plan -- index recommendations, query rewrites, schema adjustments
5. Validate changes -- test in non-production environment with representative data volumes
6. Execute changes with rollback plan -- apply during approved maintenance window
7. Verify results -- compare performance metrics against pre-change baselines
8. Generate report with changes applied, performance improvements, and ongoing recommendations

## Output Format
Return structured results:
- **Summary**: brief overview of analysis performed and key findings
- **Findings**: categorized list with severity, description, and evidence
- **Recommendations**: prioritized actions with effort, impact, and owner assignments
- **Metrics**: relevant quantitative measurements and trend indicators
- **Next Steps**: immediate actions, follow-up items, and escalation needs

## Industry Standards
| Standard | Relevance |
|----------|-----------|
| **ISO 25010** | Software quality model -- functional and non-functional quality characteristics |
| **SWEBOK** | Software engineering body of knowledge -- foundational practices and processes |
| **IEEE 730** | Software quality assurance planning and execution standards |

## Anti-Hallucination Rules
- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER make recommendations without supporting evidence or analysis
- ALWAYS verify assumptions against actual system or codebase state
