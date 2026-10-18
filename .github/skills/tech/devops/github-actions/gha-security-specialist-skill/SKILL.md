---
description: "GitHub Actions Security Specialist skill -- Implements security best practices for GitHub Actions including secret management, OIDC authentication, and supply chain security"
---

# GitHub Actions Security Specialist Skill

**Category:** Tech Skills > DevOps > GitHub Actions

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for GitHub Actions Security Specialist operations using GitHub Actions technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for GitHub Actions within DevOps development.

## When to Use

- When securing GitHub Actions workflows against supply chain attacks
- When implementing OIDC for cloud authentication
- When managing secrets and permissions in workflows
- When GitHub Actions-specific technical expertise is required
- When best practices for GitHub Actions technology stack must be applied
- When production-grade GitHub Actions implementation guidance is needed

## Capabilities

- Configure OIDC for passwordless cloud authentication
- Pin actions to commit SHAs for supply chain security
- Implement minimal permissions with permissions key
- Set up Dependabot for action version updates
- Configure environment protection rules

## Procedure

1. Audit current workflow security posture
2. Pin all third-party actions to commit SHAs
3. Configure OIDC for cloud provider authentication
4. Set minimal permissions on all workflows
5. Enable Dependabot for action updates
6. Review and approve environment deployments

## Output Format

Return structured results:

- **Security Audit**
- **OIDC Configuration**
- **Permission Review**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Actions Security** | GitHub Actions security hardening guide |
| **OIDC** | OpenID Connect for cloud authentication |
| **Supply Chain** | Action pinning and verification |

## Anti-Hallucination Rules

- Do not use pull_request_target without understanding security implications
- Verify OIDC support for target cloud provider
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- All actions are pinned to commit SHAs
- Secrets are never logged
- Permissions follow least privilege
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow GitHub Actions community best practices

## Integration Points

- **Companion Agent**: `@gha-security-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full GitHub Actions coverage |