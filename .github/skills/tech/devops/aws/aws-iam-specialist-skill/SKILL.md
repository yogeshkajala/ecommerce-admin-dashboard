---
description: "AWS IAM Specialist skill -- Configures AWS IAM policies, roles, and identity federation for secure access management following least privilege principles"
---

# AWS IAM Specialist Skill

**Category:** Tech Skills > DevOps > AWS

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for AWS IAM Specialist operations using AWS technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for AWS within DevOps development.

## When to Use

- When designing IAM policies with least privilege
- When implementing cross-account access with roles
- When configuring identity federation with SAML or OIDC
- When AWS-specific technical expertise is required
- When best practices for AWS technology stack must be applied
- When production-grade AWS implementation guidance is needed

## Capabilities

- Create IAM policies with minimal permissions
- Implement cross-account roles with trust policies
- Configure identity federation with external IdP
- Set up permission boundaries for delegation
- Analyze access with IAM Access Analyzer

## Procedure

1. Analyze access requirements per service
2. Design IAM policies with least privilege
3. Create roles for service and cross-account access
4. Configure federation for external identity
5. Set up permission boundaries
6. Review with IAM Access Analyzer

## Output Format

Return structured results:

- **IAM Policies**
- **Role Configuration**
- **Access Analysis**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **IAM Best Practices** | AWS IAM security guidelines |
| **Least Privilege** | Minimal permission assignment patterns |
| **Access Analyzer** | Unused access and external access detection |

## Anti-Hallucination Rules

- Do not use wildcard (*) actions or resources without justification
- Verify IAM features in target AWS partition
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Policies follow least privilege
- Access Analyzer shows no unintended external access
- Roles have proper trust policies
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow AWS community best practices

## Integration Points

- **Companion Agent**: `@aws-iam-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full AWS coverage |
<!-- Technology knowledge base entry for AWS IAM Specialist in AWS DevOps -->
<!-- Technology knowledge base entry for AWS IAM Specialist in AWS DevOps -->