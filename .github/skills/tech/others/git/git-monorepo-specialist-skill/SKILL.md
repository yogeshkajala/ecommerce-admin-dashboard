---
description: "Git Monorepo Specialist skill -- Manages Git monorepos with proper tooling, selective checkout, and CI/CD integration for large-scale single-repository development"
---

# Git Monorepo Specialist Skill

**Category:** Tech Skills > Others > Git

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Git Monorepo Specialist operations using Git technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Git within Others development.

## When to Use

- When managing monorepos with Git and related tools
- When implementing sparse checkout for large repositories
- When configuring CI/CD for monorepo change detection
- When Git-specific technical expertise is required
- When best practices for Git technology stack must be applied
- When production-grade Git implementation guidance is needed

## Capabilities

- Configure sparse checkout for selective work
- Implement path-based CI/CD triggers
- Use Git LFS for large file management
- Configure Nx or Turborepo for monorepo builds
- Optimize Git performance for large repos

## Procedure

1. Evaluate monorepo structure and tooling
2. Configure sparse checkout for developers
3. Set up path-based CI triggers
4. Implement build caching with Nx/Turborepo
5. Configure Git LFS for large files
6. Optimize Git performance settings

## Output Format

Return structured results:

- **Monorepo Configuration**
- **CI/CD Setup**
- **Performance Optimization**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Monorepo** | Monorepo management patterns and tools |
| **Sparse Checkout** | Selective directory checkout for performance |
| **Build Caching** | Nx and Turborepo build optimization |

## Anti-Hallucination Rules

- Do not enable Git LFS for all files - only large binaries
- Verify monorepo tools compatibility with project structure
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Developers can work on subsets efficiently
- CI only builds affected packages
- Repository performance is acceptable
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Git community best practices

## Integration Points

- **Companion Agent**: `@git-monorepo-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Git coverage |
<!-- Technology knowledge base entry for Git Monorepo Specialist in Git Others -->
<!-- Technology knowledge base entry for Git Monorepo Specialist in Git Others -->