---
name: defect-triager-skill
description: "Defect Triager skill -- Use when triaging defects, assigning severity and priority, determining SLA targets, assessing user impact, or classifying defect categories."
---
# Defect Triager Skill

## Purpose
Provides domain knowledge for triaging defects: assessing severity, assigning priority, determining SLA targets, and routing to appropriate teams.

## When to Use
- When a defect needs severity and priority assessment
- When determining SLA targets for a reported bug
- When classifying defect categories (functional, performance, security, UX)
- When assessing user impact and workaround availability

## Capabilities
- Assess defect severity using user-impact × system-impact matrix
- Assign priority based on severity, business context, and release timeline
- Apply SLA targets per severity level (P1=4h, P2=24h, P3=1 sprint, P4=backlog)
- Classify defect categories: functional, performance, security, UX, data, integration
- Determine escalation path based on severity and affected component
- Assess blast radius: isolated vs widespread impact
- Identify workarounds that reduce effective severity
- Check for duplicate or related existing defects

## Procedure
1. Receive defect report -- capture symptoms, reproduction steps, and affected area
2. Assess user impact -- how many users affected, which features, workaround available?
3. Assess system impact -- data loss risk, security exposure, cascading failures?
4. Apply severity matrix -- cross-reference user impact × system impact
5. Check if workaround exists -- reduce effective severity by 1 level if available
6. Assign severity (S1-S4) with documented rationale
7. Determine priority using business context: blocking release? critical path? customer-facing?
8. Apply SLA targets per severity level
9. Classify defect category (functional, performance, security, UX, data, integration)
10. Route to appropriate team/individual based on affected component

## Output Format
Return structured results:
- **Severity**: S1-S4 with rationale and impact evidence
- **Priority**: P1-P4 with business context justification
- **Category**: functional, performance, security, UX, data, or integration
- **SLA Targets**: response and resolution time targets
- **User Impact**: users affected, features impacted, workaround availability
- **Routing**: assigned team/individual and escalation path

## Industry Standards
| Standard | Relevance |
|----------|-----------|
| **IEEE 1044** | Software anomaly classification and resolution |
| **ISTQB Defect Management** | Defect lifecycle states and severity/priority frameworks |
| **ITIL Incident Classification** | Impact × urgency matrix for priority assignment |

## Anti-Hallucination Rules
- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER assign severity without documented impact evidence
- ALWAYS check for duplicate defects before creating new tickets
