---
description: "Incident Detector skill -- Use when identifying incidents from monitoring alerts, log anomalies, or user reports. Confirms incident validity and deduplicates."
---
# Incident Detector Skill

## Purpose
Provides domain-specific knowledge and step-by-step procedures for Incident Detector operations.

## When to Use
- When performing incident tasks that require specialized knowledge
- When structured output and validated results are needed
- When domain best practices and industry standards must be applied

## Capabilities
- Triage incoming incidents by severity using impact and urgency assessment matrices
- Perform structured root cause analysis using 5-Whys, fishbone, and fault tree methods
- Coordinate incident response workflows with clear roles and communication channels
- Escalate incidents based on defined thresholds and SLA breach predictions
- Correlate alerts and symptoms to identify cascading failure patterns
- Generate incident timelines with key events, actions taken, and resolution steps
- Produce blameless post-incident reviews with corrective action items
- Track incident metrics (MTTD, MTTA, MTTR, MTBF) for continuous improvement

## Procedure
1. Receive incident alert -- capture symptoms, affected services, and initial severity assessment
2. Triage incident -- classify severity (P1-P4) based on impact, urgency, and affected users
3. Assemble response -- identify required responders, communication channels, and escalation paths
4. Diagnose root cause -- correlate metrics, logs, and traces to identify failure point
5. Execute remediation -- apply fix, verify resolution, and monitor for recurrence
6. Communicate status updates to stakeholders at defined intervals based on severity
7. Conduct post-incident review -- document timeline, root cause, and corrective actions
8. Generate incident report with MTTD, MTTA, MTTR metrics and improvement recommendations

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
- NEVER assign root cause without supporting evidence from logs/metrics
- ALWAYS verify incident resolution before closing tickets
