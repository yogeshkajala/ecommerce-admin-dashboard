---
description: "Python Package Manager skill -- Manages Python project dependencies with pip, poetry, or uv including virtual environments, lockfiles, and package publishing"
---

# Python Package Manager Skill

**Category:** Tech Skills > Backend > Python

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Python Package Manager operations using Python technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Python within Backend development.

## When to Use

- When setting up Python project dependencies with poetry or uv
- When managing virtual environments and lockfiles
- When publishing Python packages to PyPI
- When Python-specific technical expertise is required
- When best practices for Python technology stack must be applied
- When production-grade Python implementation guidance is needed

## Capabilities

- Configure pyproject.toml with proper metadata
- Manage dependencies with poetry or uv
- Set up virtual environments with proper isolation
- Generate and maintain lockfiles for reproducibility
- Publish packages to PyPI with proper versioning

## Procedure

1. Choose dependency management tool
2. Configure pyproject.toml with project metadata
3. Set up virtual environment
4. Add and manage dependencies
5. Generate lockfile for reproducible installs
6. Configure CI/CD for package publishing if needed

## Output Format

Return structured results:

- **Project Configuration**
- **Dependency Lock**
- **Publishing Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **PEP 621** | Project metadata in pyproject.toml |
| **Poetry** | Dependency management and packaging |
| **uv** | Fast Python package installer and resolver |

## Anti-Hallucination Rules

- Do not mix pip and poetry dependency management in the same project
- Verify tool compatibility with target Python version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Lockfile is committed and reproducible
- Virtual environment is properly isolated
- No conflicting dependency versions exist
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Python community best practices

## Integration Points

- **Companion Agent**: `@python-package-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Python coverage |
<!-- Technology knowledge base entry for Python Package Manager in Python Backend -->
<!-- Technology knowledge base entry for Python Package Manager in Python Backend -->