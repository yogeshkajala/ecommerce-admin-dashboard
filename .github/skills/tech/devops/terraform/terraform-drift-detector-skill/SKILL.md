---
description: "Terraform Drift Detector skill -- Detects and remediates infrastructure drift between Terraform state and actual cloud resources for configuration consistency"
---

# Terraform Drift Detector Skill

**Category:** Tech Skills > DevOps > Terraform

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Terraform Drift Detector operations using Terraform technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Terraform within DevOps development.

## When to Use

- When detecting infrastructure drift from desired state
- When investigating unexpected resource changes
- When automating drift detection in CI/CD pipelines
- When Terraform-specific technical expertise is required
- When best practices for Terraform technology stack must be applied
- When production-grade Terraform implementation guidance is needed

## Capabilities

- Detect drift with terraform plan in CI/CD
- Implement scheduled drift detection workflows
- Analyze drift causes and impact
- Automate drift remediation with apply
- Configure notifications for drift detection

## Procedure

1. Schedule periodic terraform plan runs
2. Compare plan output for unexpected changes
3. Investigate drift causes
4. Determine remediation: apply or import
5. Update configuration if drift is intentional
6. Set up alerting for drift detection

## Output Format

Return structured results:

- **Drift Report**
- **Remediation Plan**
- **Automation Config**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Drift Detection** | Infrastructure drift detection methodology |
| **Continuous Compliance** | Scheduled configuration verification |
| **Remediation** | Drift resolution strategies |

## Anti-Hallucination Rules

- Do not auto-remediate drift without understanding the cause
- Verify drift detection works with all managed resources
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Drift is detected within defined SLA
- Remediation does not cause downtime
- All managed resources are checked for drift
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Terraform community best practices

## Integration Points

- **Companion Agent**: `@terraform-drift-detector` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Terraform coverage |
<!-- Technology knowledge base entry for Terraform Drift Detector in Terraform DevOps -->
<!-- Technology knowledge base entry for Terraform Drift Detector in Terraform DevOps -->