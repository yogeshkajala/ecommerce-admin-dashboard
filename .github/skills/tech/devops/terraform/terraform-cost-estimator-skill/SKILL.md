---
description: "Terraform Cost Estimator skill -- Estimates infrastructure costs from Terraform plans using Infracost and implements cost policies for budget management"
---

# Terraform Cost Estimator Skill

**Category:** Tech Skills > DevOps > Terraform

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Terraform Cost Estimator operations using Terraform technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Terraform within DevOps development.

## When to Use

- When estimating costs before infrastructure changes
- When implementing cost policies and budgets
- When integrating cost estimation into CI/CD pipelines
- When Terraform-specific technical expertise is required
- When best practices for Terraform technology stack must be applied
- When production-grade Terraform implementation guidance is needed

## Capabilities

- Estimate costs with Infracost for Terraform plans
- Implement cost policies with thresholds
- Generate cost reports for pull requests
- Compare costs between environments
- Track cost trends over time

## Procedure

1. Integrate Infracost with CI/CD pipeline
2. Configure pricing for custom resources
3. Set cost thresholds and policies
4. Generate cost reports on pull requests
5. Track cost trends across deployments
6. Alert on cost anomalies

## Output Format

Return structured results:

- **Cost Estimate**
- **Policy Configuration**
- **Trend Report**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Infracost** | Cost estimation tool and API |
| **FinOps** | Cloud financial management practices |
| **Cost Policies** | Budget enforcement with policy-as-code |

## Anti-Hallucination Rules

- Do not assume cost estimates are exact - they are approximations
- Verify Infracost pricing data is current
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Cost estimates are within 15% of actual costs
- Policies catch over-budget changes
- Reports are generated for every change
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Terraform community best practices

## Integration Points

- **Companion Agent**: `@terraform-cost-estimator` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Terraform coverage |
<!-- Technology knowledge base entry for Terraform Cost Estimator in Terraform DevOps -->
<!-- Technology knowledge base entry for Terraform Cost Estimator in Terraform DevOps -->