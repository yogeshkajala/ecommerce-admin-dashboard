---
description: "GitHub Actions Artifact Manager skill -- Manages build artifacts in GitHub Actions workflows including upload/download, caching strategies, and artifact retention policies"
---

# GitHub Actions Artifact Manager Skill

**Category:** Tech Skills > DevOps > GitHub Actions

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for GitHub Actions Artifact Manager operations using GitHub Actions technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for GitHub Actions within DevOps development.

## When to Use

- When sharing artifacts between workflow jobs
- When implementing caching for build dependencies
- When managing artifact retention and cleanup
- When GitHub Actions-specific technical expertise is required
- When best practices for GitHub Actions technology stack must be applied
- When production-grade GitHub Actions implementation guidance is needed

## Capabilities

- Upload and download artifacts between jobs
- Configure dependency caching with actions/cache
- Implement custom cache keys for invalidation
- Set retention policies for artifact cleanup
- Share data between workflow runs

## Procedure

1. Identify artifacts needed between jobs
2. Configure upload/download with proper naming
3. Set up caching for package managers
4. Design cache key strategy for invalidation
5. Configure retention policies
6. Monitor artifact storage usage

## Output Format

Return structured results:

- **Artifact Configuration**
- **Cache Strategy**
- **Retention Policy**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Artifacts** | actions/upload-artifact and download-artifact |
| **Caching** | Dependency caching patterns and key design |
| **Retention** | Artifact and log retention configuration |

## Anti-Hallucination Rules

- Do not upload sensitive data as artifacts
- Verify artifact action version compatibility
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Artifacts are available in dependent jobs
- Cache hit rates are monitored
- Storage usage is within budget
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow GitHub Actions community best practices

## Integration Points

- **Companion Agent**: `@gha-artifact-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full GitHub Actions coverage |
<!-- Technology knowledge base entry for GitHub Actions Artifact Manager in GitHub Actions DevOps -->