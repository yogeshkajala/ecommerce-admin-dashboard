---
description: "GitHub Actions Workflow Builder skill -- Creates GitHub Actions workflows for CI/CD automation with proper trigger configuration, job design, and artifact management"
---

# GitHub Actions Workflow Builder Skill

**Category:** Tech Skills > DevOps > GitHub Actions

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for GitHub Actions Workflow Builder operations using GitHub Actions technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for GitHub Actions within DevOps development.

## When to Use

- When building CI/CD workflows with GitHub Actions
- When configuring workflow triggers and conditions
- When implementing multi-job workflows with dependencies
- When GitHub Actions-specific technical expertise is required
- When best practices for GitHub Actions technology stack must be applied
- When production-grade GitHub Actions implementation guidance is needed

## Capabilities

- Design workflows with proper trigger events
- Configure jobs with dependency chains
- Implement matrix strategies for multi-platform builds
- Manage artifacts and caching between jobs
- Configure secrets and environment protection rules

## Procedure

1. Design workflow trigger strategy
2. Implement jobs with proper steps
3. Configure matrix for multi-platform builds
4. Add caching for dependency optimization
5. Set up secrets and environments
6. Test workflow with act or feature branch

## Output Format

Return structured results:

- **Workflow File**
- **Matrix Configuration**
- **Cache Strategy**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **GitHub Actions** | Workflow syntax and best practices |
| **Matrix Strategy** | Multi-platform and multi-version builds |
| **Caching** | actions/cache for dependency optimization |

## Anti-Hallucination Rules

- Do not hardcode secrets in workflow files
- Verify action version compatibility
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Workflows trigger on correct events
- Matrix covers all target platforms
- Caching reduces build times
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow GitHub Actions community best practices

## Integration Points

- **Companion Agent**: `@gha-workflow-builder` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full GitHub Actions coverage |
<!-- Technology knowledge base entry for GitHub Actions Workflow Builder in GitHub Actions DevOps -->