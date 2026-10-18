---
description: "Health Monitor skill -- Use when monitoring deployment health to detect failures, degradation, and trigger rollback decisions."
---
# Health Monitor Skill

## Purpose
Provides domain-specific knowledge and step-by-step procedures for Health Monitor operations.

## When to Use
- When performing observability tasks that require specialized knowledge
- When structured output and validated results are needed
- When domain best practices and industry standards must be applied

## Capabilities
- Configure and validate observability pipelines for metrics, logs, and traces
- Define SLOs, SLIs, and error budgets aligned with business objectives
- Design alert rules with appropriate thresholds, windows, and escalation paths
- Analyze telemetry data to identify performance anomalies and degradation trends
- Build dashboards providing actionable visibility into system health and SLO burn rates
- Correlate signals across metrics, logs, and traces for root cause identification
- Evaluate monitoring coverage gaps across services and infrastructure layers
- Implement structured logging standards and trace context propagation

## Procedure
1. Receive observability request -- identify target services, SLOs, and monitoring requirements
2. Audit existing telemetry coverage -- identify gaps in metrics, logs, and trace instrumentation
3. Define or validate SLIs and SLOs based on user journeys and business objectives
4. Configure alert rules with appropriate thresholds, evaluation windows, and notification channels
5. Validate alert quality -- check for noise ratio, false positive rate, and actionability
6. Build or review dashboards ensuring they provide actionable operational visibility
7. Test observability pipeline end-to-end -- verify data flow from instrumentation to visualization
8. Generate observability assessment report with coverage score, gap analysis, and recommendations

## Output Format
Return structured results:
- **Coverage Score**: percentage of services with metrics, logs, and traces instrumented
- **SLO Status**: SLO name, target, current value, error budget remaining, burn rate
- **Alert Quality**: total alerts, actionable percentage, noise ratio, MTTA impact
- **Gap Analysis**: services or layers missing telemetry coverage with remediation priority
- **Dashboard Assessment**: completeness, actionability, and recommended improvements

## Industry Standards
| Standard | Relevance |
|----------|-----------|
| **Google SRE Book** | SLO/SLI framework, error budgets, and alerting philosophy |
| **OpenTelemetry** | Vendor-neutral telemetry collection -- metrics, logs, traces standards |
| **USE/RED Methods** | Infrastructure (Utilization, Saturation, Errors) and service (Rate, Errors, Duration) analysis |

## Anti-Hallucination Rules
- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER set alert thresholds without baseline data analysis
- ALWAYS verify SLO calculations against actual service-level data
