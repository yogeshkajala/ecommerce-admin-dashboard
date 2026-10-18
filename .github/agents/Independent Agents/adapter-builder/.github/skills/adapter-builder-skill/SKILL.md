---
description: "Adapter Builder skill -- Build adapters and anti-corruption layers for legacy-modern coexistence."
---
# Adapter Builder Skill

## Purpose
Provides domain-specific knowledge and step-by-step procedures for Adapter Builder operations.

## When to Use
- When performing cicd tasks that require specialized knowledge
- When structured output and validated results are needed
- When domain best practices and industry standards must be applied

## Capabilities
- Design CI/CD pipeline configurations for build, test, and deployment stages
- Validate pipeline definitions for security, efficiency, and best practices
- Manage build artifacts including versioning, storage, and promotion workflows
- Configure pipeline triggers, gates, and approval workflows
- Analyze pipeline execution metrics (duration, failure rates, queue times)
- Implement caching strategies to optimize build and test execution times
- Integrate static analysis, security scanning, and compliance checks into pipelines
- Generate pipeline health reports with bottleneck identification and optimization suggestions

## Procedure
1. Receive CI/CD request -- identify pipeline scope, target platforms, and quality requirements
2. Analyze current pipeline -- review stages, duration, failure rates, and configuration quality
3. Design pipeline improvements -- optimize stages, caching, parallelization, and gate criteria
4. Validate pipeline configuration -- check for security, secret handling, and best practices
5. Implement changes -- update pipeline definitions with proper testing and rollback support
6. Execute pipeline run -- monitor stage execution, collect metrics, and verify outputs
7. Verify artifacts -- validate build outputs, test results, and deployment readiness
8. Generate pipeline report with execution metrics, optimization suggestions, and health score

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
