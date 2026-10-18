---
description: "GitHub Actions Self-Hosted Runner Specialist skill -- Deploys and manages GitHub Actions self-hosted runners with autoscaling, security hardening, and runner groups for enterprise use"
---

# GitHub Actions Self-Hosted Runner Specialist Skill

**Category:** Tech Skills > DevOps > GitHub Actions

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for GitHub Actions Self-Hosted Runner Specialist operations using GitHub Actions technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for GitHub Actions within DevOps development.

## When to Use

- When deploying self-hosted runners for specialized hardware needs
- When implementing autoscaling runners with actions-runner-controller
- When securing self-hosted runner infrastructure
- When GitHub Actions-specific technical expertise is required
- When best practices for GitHub Actions technology stack must be applied
- When production-grade GitHub Actions implementation guidance is needed

## Capabilities

- Deploy self-hosted runners on Linux, macOS, Windows
- Configure actions-runner-controller for Kubernetes
- Implement runner autoscaling based on demand
- Secure runners with proper isolation
- Manage runner groups and labels

## Procedure

1. Assess self-hosted runner requirements
2. Deploy runner infrastructure
3. Configure autoscaling with ARC if on K8s
4. Implement security hardening
5. Set up runner groups and labels
6. Monitor runner health and utilization

## Output Format

Return structured results:

- **Runner Configuration**
- **Autoscaling Setup**
- **Security Hardening**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Self-Hosted Runners** | Runner deployment and management |
| **ARC** | Actions Runner Controller for Kubernetes |
| **Runner Security** | Self-hosted runner security hardening |

## Anti-Hallucination Rules

- Do not run self-hosted runners on public repositories without hardening
- Verify runner compatibility with GitHub Enterprise version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Runners scale to meet demand
- Security hardening prevents compromise
- Runner groups restrict access appropriately
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow GitHub Actions community best practices

## Integration Points

- **Companion Agent**: `@gha-self-hosted-runner-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full GitHub Actions coverage |