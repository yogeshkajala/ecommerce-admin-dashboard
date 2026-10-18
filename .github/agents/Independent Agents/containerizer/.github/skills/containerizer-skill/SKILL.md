---
description: "Containerizer skill -- Use when containerizing applications with optimized Dockerfiles, multi-stage builds, and security hardening."
---
# Containerizer Skill

## Purpose
Provides domain-specific knowledge and step-by-step procedures for Containerizer operations.

## When to Use
- When performing infrastructure tasks that require specialized knowledge
- When structured output and validated results are needed
- When domain best practices and industry standards must be applied

## Capabilities
- Assess infrastructure health across compute, network, storage, and container layers
- Design infrastructure-as-code templates following cloud provider best practices
- Evaluate capacity utilization and recommend scaling strategies (horizontal/vertical)
- Validate network security configurations including firewalls, NACLs, and security groups
- Monitor container orchestration health (Kubernetes pods, services, deployments)
- Plan disaster recovery with RTO/RPO targets and failover testing procedures
- Analyze infrastructure costs and recommend reserved instance or savings plan strategies
- Generate infrastructure audit reports with compliance and drift detection findings

## Procedure
1. Receive infrastructure request -- identify scope, target environment, and operational requirements
2. Audit current state -- inventory resources, configurations, utilization, and compliance posture
3. Assess health -- check compute, network, storage, and container layer health indicators
4. Identify issues -- capacity constraints, security misconfigurations, drift from desired state
5. Design remediation -- infrastructure changes, scaling adjustments, or configuration corrections
6. Validate changes -- test in staging environment with automated verification
7. Execute changes following change management process with rollback procedures
8. Generate infrastructure report with findings, actions taken, and health score improvements

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
