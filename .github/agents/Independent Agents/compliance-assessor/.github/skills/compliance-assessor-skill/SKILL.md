---
description: "Compliance Assessor skill -- Use when assessing compliance and regulatory requirements that constrain cloud modernization decisions."
---
# Compliance Assessor Skill

## Purpose
Provides domain-specific knowledge and step-by-step procedures for Compliance Assessor operations.

## When to Use
- When performing review tasks that require specialized knowledge
- When structured output and validated results are needed
- When domain best practices and industry standards must be applied

## Capabilities
- Conduct structured code and architecture reviews against established standards
- Evaluate compliance posture against regulatory frameworks (SOC2, GDPR, HIPAA, PCI-DSS)
- Generate audit findings with severity classification and remediation recommendations
- Assess control effectiveness through evidence collection and gap analysis
- Review change requests for risk, impact, and rollback readiness
- Validate documentation completeness and accuracy against requirements
- Produce compliance reports with control mapping and attestation evidence
- Track remediation progress and verify corrective action implementation

## Procedure
1. Receive review request -- identify scope, review type, and applicable standards or frameworks
2. Gather evidence -- collect artifacts, configurations, logs, and documentation for assessment
3. Evaluate against checklist -- apply relevant standards, policies, and best practices
4. Classify findings by severity and impact -- Critical, High, Medium, Low, Informational
5. Assess control effectiveness -- determine if controls are designed and operating effectively
6. Generate remediation recommendations with priority, effort, and responsible party
7. Validate remediation completeness through follow-up evidence collection
8. Produce review report with findings, compliance status, and improvement roadmap

## Output Format
Return structured results:
- **Compliance Score**: overall compliance percentage with framework-specific breakdown
- **Findings**: ID, severity, category, description, evidence, remediation recommendation
- **Control Assessment**: control ID, design effectiveness, operating effectiveness, gaps
- **Risk Matrix**: risk category, likelihood, impact, current controls, residual risk
- **Action Items**: prioritized remediation tasks with owners, deadlines, and verification criteria

## Industry Standards
| Standard | Relevance |
|----------|-----------|
| **SOC 2 Type II** | Trust service criteria -- Security, Availability, Processing Integrity, Confidentiality, Privacy |
| **ISO 27001** | Information security management system -- risk assessment and controls |
| **COBIT 2019** | IT governance framework -- control objectives and maturity assessment |

## Anti-Hallucination Rules
- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER make recommendations without supporting evidence or analysis
- ALWAYS verify assumptions against actual system or codebase state
