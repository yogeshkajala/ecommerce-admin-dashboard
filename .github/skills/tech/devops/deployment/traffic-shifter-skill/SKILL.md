---
description: "Traffic Shifter skill -- Use when shifting traffic between deployment versions during rollback, canary, or blue-green operations."
---

# Traffic Shifter Skill

**Category:** Tech Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Traffic Shifter operations. This skill encapsulates technology-specific patterns, toolchain expertise, and implementation best practices.

## When to Use

- When shifting traffic between deployment versions during rollback, canary, or blue-green operations
- When technology-specific patterns and toolchain expertise are required
- When automated scanning, analysis, or code generation is needed
- When integration with development tools and CI/CD pipelines is required

## Capabilities

- Configure CI/CD pipelines with build, test, scan, and deploy stages
- Execute deployment strategies: rolling, blue-green, canary, and progressive rollout
- Manage environment promotion workflows with approval gates
- Validate deployment health through automated smoke tests and metric checks
- Execute rollback procedures with state restoration and data consistency
- Manage feature flags for controlled feature activation and dark launches
- Generate deployment manifests for Kubernetes, Docker Compose, or cloud-native targets
- Produce deployment audit trails with version, approver, and timestamp tracking

## Procedure

1. Receive deployment request -- identify target environment, artifact version, and deployment strategy
2. Validate deployment prerequisites: artifact integrity, configuration completeness, approval status
3. Prepare deployment manifest with environment-specific configuration and secrets references
4. Execute pre-deployment checks: health verification, capacity validation, rollback readiness
5. Deploy artifact using configured strategy (rolling, blue-green, canary, or progressive)
6. Monitor deployment health metrics: error rates, latency, resource utilization
7. Execute post-deployment verification: smoke tests, health checks, integration validation
8. Finalize deployment or trigger rollback based on health gate evaluation
9. Generate deployment report with timeline, metrics, and status

## Output Format

Return structured results:

- **Summary**: operation performed, scope, and execution status
- **Findings**: issue ID, severity, file/location, description, remediation
- **Metrics**: quantitative measurements (coverage, complexity, performance, counts)
- **Quality Gate**: PASS/FAIL with gate criteria evaluation details
- **Recommendations**: prioritized improvement actions with effort estimates

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
- NEVER report tool output without actual execution evidence
- ALWAYS verify version compatibility before applying technology-specific patterns

## Constraints

- NEVER execute destructive operations without explicit user confirmation
- NEVER store, log, or expose secrets, credentials, or PII in output
- ALWAYS provide evidence for assertions -- no claims without supporting data
- ALWAYS follow the principle of least privilege for tool and data access
- NEVER bypass security checks or disable safety validations
- ALWAYS use the appropriate tool version matching the target environment
