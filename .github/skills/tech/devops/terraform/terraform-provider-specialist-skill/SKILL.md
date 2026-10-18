---
description: "Terraform Provider Specialist skill -- Configures and optimizes Terraform providers for AWS, Azure, GCP, and Kubernetes with proper authentication and feature management"
---

# Terraform Provider Specialist Skill

**Category:** Tech Skills > DevOps > Terraform

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Terraform Provider Specialist operations using Terraform technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Terraform within DevOps development.

## When to Use

- When configuring cloud providers with proper authentication
- When managing provider versions and constraints
- When implementing multi-region and multi-account deployments
- When Terraform-specific technical expertise is required
- When best practices for Terraform technology stack must be applied
- When production-grade Terraform implementation guidance is needed

## Capabilities

- Configure AWS, Azure, and GCP providers
- Implement multi-region deployments with provider aliases
- Manage provider version constraints
- Configure authentication with OIDC and managed identity
- Handle provider-specific features and data sources

## Procedure

1. Choose providers for target infrastructure
2. Configure authentication securely
3. Set version constraints for stability
4. Implement provider aliases for multi-region
5. Configure provider features and endpoints
6. Test provider connectivity and permissions

## Output Format

Return structured results:

- **Provider Configuration**
- **Auth Setup**
- **Version Constraints**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Provider Configuration** | Authentication and feature configuration |
| **Version Constraints** | Provider version pinning best practices |
| **Multi-Region** | Provider alias patterns for multi-region |

## Anti-Hallucination Rules

- Do not hardcode credentials in provider configuration
- Verify provider features in target version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Authentication uses identity-based access
- Provider versions are pinned for reproducibility
- Multi-region deployments work correctly
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Terraform community best practices

## Integration Points

- **Companion Agent**: `@terraform-provider-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Terraform coverage |