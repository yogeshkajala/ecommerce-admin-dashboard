---
description: "GitHub Actions Composite Action Developer skill -- Creates reusable composite actions and JavaScript actions for shared CI/CD logic across GitHub repositories"
---

# GitHub Actions Composite Action Developer Skill

**Category:** Tech Skills > DevOps > GitHub Actions

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for GitHub Actions Composite Action Developer operations using GitHub Actions technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for GitHub Actions within DevOps development.

## When to Use

- When building reusable actions for shared CI/CD steps
- When creating composite actions with multiple steps
- When publishing actions to GitHub Marketplace
- When GitHub Actions-specific technical expertise is required
- When best practices for GitHub Actions technology stack must be applied
- When production-grade GitHub Actions implementation guidance is needed

## Capabilities

- Build composite actions with inputs and outputs
- Create JavaScript/TypeScript actions with toolkit
- Define proper action metadata with action.yml
- Implement input validation and error handling
- Publish actions to GitHub Marketplace

## Procedure

1. Design action interface with inputs/outputs
2. Implement action logic
3. Configure action.yml metadata
4. Test action in isolation
5. Version action with semantic tags
6. Publish to Marketplace if public

## Output Format

Return structured results:

- **Action Implementation**
- **Metadata Configuration**
- **Test Workflow**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Action Metadata** | action.yml specification and patterns |
| **Composite Actions** | Multi-step reusable action patterns |
| **Action Toolkit** | @actions/core and @actions/github packages |

## Anti-Hallucination Rules

- Do not use deprecated action runner features
- Verify action runner compatibility with target environments
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Action handles all input variations
- Error messages are descriptive
- Action is versioned with proper tags
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow GitHub Actions community best practices

## Integration Points

- **Companion Agent**: `@gha-composite-action-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full GitHub Actions coverage |
<!-- Technology knowledge base entry for GitHub Actions Composite Action Developer in GitHub Actions DevOps -->