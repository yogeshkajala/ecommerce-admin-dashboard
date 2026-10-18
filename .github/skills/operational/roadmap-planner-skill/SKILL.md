---
description: "Roadmap Planner skill -- Use when planning dependency-ordered migration waves, resource-optimized transformation timelines, or phased modernization roadmaps with milestones."
---

# Roadmap Planner Skill

**Category:** Domain Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Roadmap Planner operations. This skill encapsulates domain expertise, business processes, compliance requirements, and industry-standard frameworks.

## When to Use

- When planning dependency-ordered migration waves, resource-optimized transformation timelines, or phased modernization roadmaps with milestones
- When business process knowledge and industry standards must be applied
- When compliance, governance, or regulatory requirements are involved
- When domain-specific risk assessment and mitigation planning are needed

## Capabilities

- Assess source systems for migration readiness and complexity
- Classify migration strategy using 7R framework
- Plan migration waves with dependency ordering and cutover scheduling
- Execute data migration with integrity verification and rollback readiness
- Validate migrated functionality through regression and performance testing
- Manage coexistence and parallel-run validation between old and new systems
- Track migration progress with workload status and risk indicators
- Generate migration reports with status, validation results, and decommission planning

## Procedure

1. Receive migration request -- identify source system, target platform, and migration scope
2. Assess source system: technology stack, dependencies, data volumes, and complexity
3. Classify migration strategy using 7R framework (rehost, replatform, refactor, etc.)
4. Plan migration sequence: dependency ordering, wave planning, cutover scheduling
5. Execute migration steps with validation checkpoints and rollback readiness
6. Verify data integrity: record counts, checksums, referential integrity validation
7. Test migrated functionality: smoke tests, regression tests, performance benchmarks
8. Validate operational readiness: monitoring, alerting, runbooks, team training
9. Generate migration report with status, validation results, and decommission timeline

## Output Format

Return structured results:

- **Executive Summary**: key findings, risk level, and recommended actions
- **Findings**: finding ID, severity, category, description, evidence, remediation
- **Compliance Status**: framework, control ID, status (compliant/non-compliant/partial)
- **Action Items**: prioritized actions with ownership, timeline, and success criteria
- **Risk Assessment**: identified risks with likelihood, impact, and mitigation plans

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **IEEE 730** | Software quality assurance processes and standards |
| **ISO 25010** | Software quality model: functional suitability, reliability, maintainability |

## Anti-Hallucination Rules

- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER claim compliance without evidence from actual control evaluation
- ALWAYS verify regulatory applicability for the specific jurisdiction and context

## Constraints

- NEVER execute destructive operations without explicit user confirmation
- NEVER store, log, or expose secrets, credentials, or PII in output
- ALWAYS provide evidence for assertions -- no claims without supporting data
- ALWAYS follow the principle of least privilege for tool and data access
- NEVER override compliance requirements without documented exception approval
- ALWAYS maintain audit trail for all assessments and decisions
