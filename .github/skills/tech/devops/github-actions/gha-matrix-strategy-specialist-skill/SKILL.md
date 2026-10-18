---
description: "GitHub Actions Matrix Strategy Specialist skill -- Designs complex matrix strategies for GitHub Actions to test across multiple platforms, versions, and configurations efficiently"
---

# GitHub Actions Matrix Strategy Specialist Skill

**Category:** Tech Skills > DevOps > GitHub Actions

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for GitHub Actions Matrix Strategy Specialist operations using GitHub Actions technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for GitHub Actions within DevOps development.

## When to Use

- When testing across multiple OS, language versions, and configurations
- When implementing matrix exclusions and inclusions
- When optimizing matrix builds with fail-fast and max-parallel
- When GitHub Actions-specific technical expertise is required
- When best practices for GitHub Actions technology stack must be applied
- When production-grade GitHub Actions implementation guidance is needed

## Capabilities

- Design matrix strategies with multiple dimensions
- Configure exclusions and dynamic includes
- Implement fail-fast and max-parallel settings
- Use matrix outputs for downstream jobs
- Generate dynamic matrices from scripts

## Procedure

1. Analyze test matrix requirements
2. Design matrix dimensions
3. Configure exclusions for invalid combinations
4. Set fail-fast and concurrency limits
5. Implement dynamic matrix generation if needed
6. Optimize matrix for build time and coverage

## Output Format

Return structured results:

- **Matrix Configuration**
- **Exclusion Rules**
- **Performance Analysis**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Matrix Strategy** | GitHub Actions matrix configuration |
| **Dynamic Matrix** | Generating matrices from job outputs |
| **Concurrency** | Managing parallel job execution |

## Anti-Hallucination Rules

- Do not create excessively large matrices that waste runner minutes
- Verify matrix combinations produce valid configurations
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Matrix covers all required combinations
- Invalid combinations are excluded
- Build times are reasonable for matrix size
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow GitHub Actions community best practices

## Integration Points

- **Companion Agent**: `@gha-matrix-strategy-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full GitHub Actions coverage |