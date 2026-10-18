---
description: "Capacity Planner skill -- Use when planning capacity, auto-scaling policies, and resource sizing for modernized services."
---

# Capacity Planner Skill

**Category:** Tech Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Capacity Planner operations. This skill encapsulates technology-specific patterns, toolchain expertise, and implementation best practices.

## When to Use

- When planning capacity, auto-scaling policies, and resource sizing for modernized services
- When technology-specific patterns and toolchain expertise are required
- When automated scanning, analysis, or code generation is needed
- When integration with development tools and CI/CD pipelines is required

## Capabilities

- Provision and configure cloud infrastructure across AWS, Azure, and GCP
- Validate infrastructure-as-code templates for security and compliance
- Execute capacity planning based on workload patterns and growth projections
- Configure auto-scaling policies with appropriate thresholds and cooldowns
- Manage container orchestration: pods, services, ingress, and storage
- Implement network segmentation, security groups, and access controls
- Optimize resource allocation for cost efficiency without sacrificing performance
- Generate infrastructure documentation with architecture diagrams and runbooks

## Procedure

1. Receive infrastructure request -- identify target resources, operations, and constraints
2. Discover current infrastructure state: resources, configurations, dependencies
3. Validate infrastructure-as-code templates for syntax, security, and best practices
4. Plan infrastructure changes with dependency ordering and rollback strategy
5. Execute changes incrementally with validation checkpoints at each step
6. Verify resource health and connectivity after provisioning
7. Configure monitoring and alerting for new infrastructure components
8. Document infrastructure changes with architecture diagrams and runbook updates
9. Generate infrastructure report with resources created, costs, and operational notes

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
