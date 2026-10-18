---
description: "Terraform Plan Reviewer skill -- Reviews and validates Terraform plans with policy enforcement, cost estimation, and change impact analysis before apply"
---

# Terraform Plan Reviewer Skill

**Category:** Tech Skills > DevOps > Terraform

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Terraform Plan Reviewer operations using Terraform technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Terraform within DevOps development.

## When to Use

- When reviewing Terraform plans for safety before apply
- When implementing policy checks with OPA or Sentinel
- When estimating costs of infrastructure changes
- When Terraform-specific technical expertise is required
- When best practices for Terraform technology stack must be applied
- When production-grade Terraform implementation guidance is needed

## Capabilities

- Analyze terraform plan output for change impact
- Implement OPA policies for plan validation
- Estimate costs with Infracost integration
- Detect security issues with tfsec or Checkov
- Build CI/CD plan review workflows

## Procedure

1. Run terraform plan and capture output
2. Analyze changes for safety and impact
3. Run policy checks with OPA or Sentinel
4. Estimate cost impact with Infracost
5. Scan for security issues
6. Approve or reject based on findings

## Output Format

Return structured results:

- **Plan Analysis**
- **Policy Results**
- **Cost Estimate**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Plan Analysis** | Terraform plan review methodology |
| **OPA Policies** | Policy-as-code for infrastructure |
| **Infracost** | Cost estimation for infrastructure changes |

## Anti-Hallucination Rules

- Do not auto-apply plans without review for production
- Verify policy tool compatibility with Terraform version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- All plans are reviewed before apply
- Policy violations are caught
- Cost estimates are accurate within 10%
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Terraform community best practices

## Integration Points

- **Companion Agent**: `@terraform-plan-reviewer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Terraform coverage |
<!-- Technology knowledge base entry for Terraform Plan Reviewer in Terraform DevOps -->
<!-- Technology knowledge base entry for Terraform Plan Reviewer in Terraform DevOps -->