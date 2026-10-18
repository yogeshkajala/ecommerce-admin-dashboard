---
description: "Cost Modeler skill -- Use when modeling total cost of ownership (TCO) comparing on-premises vs cloud costs including compute, storage, network, licensing, and operational overhead."
---
# Cost Modeler Skill

## Purpose
Provides domain-specific knowledge and step-by-step procedures for Cost Modeler operations.

## When to Use
- When performing cost tasks that require specialized knowledge
- When structured output and validated results are needed
- When domain best practices and industry standards must be applied

## Capabilities
- Analyze cloud spending patterns and identify cost optimization opportunities
- Model cost projections for infrastructure changes and scaling scenarios
- Evaluate resource utilization and recommend right-sizing adjustments
- Calculate ROI and total cost of ownership for technology investments
- Identify waste from idle resources, over-provisioned instances, and unused licenses
- Design FinOps practices with tagging strategies and cost allocation models
- Benchmark spending against industry standards and historical baselines
- Generate cost reports with trend analysis and actionable recommendations

## Procedure
1. Receive cost analysis request -- identify scope, time period, and optimization targets
2. Collect spending data -- gather billing records, resource utilization, and commitment usage
3. Analyze spending patterns -- identify trends, anomalies, and top cost drivers
4. Identify optimization opportunities -- unused resources, over-provisioning, missing commitments
5. Model savings scenarios with projected impact, implementation effort, and risk assessment
6. Prioritize recommendations by savings potential, ease of implementation, and business impact
7. Validate recommendations against performance requirements and SLA constraints
8. Generate cost report with findings, savings projections, and implementation roadmap

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
