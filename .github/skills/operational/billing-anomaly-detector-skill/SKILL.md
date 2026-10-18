---
description: "Billing Anomaly Detector skill -- Detect billing anomalies, unexpected cost spikes, budget threshold breaches, and misconfigured resources driving excess spending."
---

# Billing Anomaly Detector Skill

**Category:** Domain Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Billing Anomaly Detector operations. This skill encapsulates domain expertise, business processes, compliance requirements, and industry-standard frameworks.

## When to Use

- When Detect billing anomalies, unexpected cost spikes, budget threshold breaches, and misconfigured resources driving excess spending
- When business process knowledge and industry standards must be applied
- When compliance, governance, or regulatory requirements are involved
- When domain-specific risk assessment and mitigation planning are needed

## Capabilities

- Analyze cloud spending across services, teams, and environments
- Identify cost optimization opportunities: idle resources, over-provisioning, licensing waste
- Model ROI scenarios for technology investments and migrations
- Track budget utilization with alerting on threshold breaches
- Forecast cost trends based on historical patterns and growth projections
- Calculate total cost of ownership (TCO) for build vs buy decisions
- Generate FinOps reports with savings recommendations and accountability
- Implement showback/chargeback models for cost transparency

## Procedure

1. Receive cost analysis request -- identify scope, time period, and optimization targets
2. Collect cost data: billing records, resource utilization, reserved capacity usage
3. Analyze spending patterns: by service, team, environment, and resource type
4. Identify optimization opportunities: idle resources, over-provisioned instances, licensing waste
5. Calculate potential savings with implementation effort and risk assessment
6. Model ROI scenarios: immediate wins, medium-term optimizations, strategic investments
7. Generate recommendations prioritized by savings potential and implementation complexity
8. Track optimization progress against targets and budget thresholds
9. Produce cost report with spending trends, savings achieved, and forecast projections

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
| **FinOps Framework** | Cloud financial management: inform, optimize, operate |
| **Well-Architected (Cost)** | Cost optimization pillar: right-sizing, reserved capacity, waste elimination |

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
