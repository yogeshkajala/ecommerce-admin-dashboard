---
description: "Python Type Checker skill -- Implements static type checking in Python with mypy, pyright, and type annotations for improved code reliability and IDE support"
---

# Python Type Checker Skill

**Category:** Tech Skills > Backend > Python

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Python Type Checker operations using Python technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Python within Backend development.

## When to Use

- When adding type annotations to Python codebases
- When configuring mypy or pyright for strict type checking
- When creating Protocol classes and generic types
- When Python-specific technical expertise is required
- When best practices for Python technology stack must be applied
- When production-grade Python implementation guidance is needed

## Capabilities

- Add type annotations to functions and classes
- Configure mypy with strict checking options
- Create Protocol classes for structural typing
- Implement generic types with TypeVar and ParamSpec
- Build overloaded function signatures with @overload

## Procedure

1. Assess type coverage of the codebase
2. Configure type checker with appropriate strictness
3. Add type annotations incrementally
4. Create type stubs for untyped libraries
5. Resolve type errors and edge cases
6. Validate type coverage meets project goals

## Output Format

Return structured results:

- **Type Configuration**
- **Coverage Report**
- **Type Stubs**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **PEP 484** | Type hints specification for Python |
| **mypy Documentation** | Static type checking configuration and patterns |
| **pyright** | Fast type checker with strict mode |

## Anti-Hallucination Rules

- Do not use typing features not available in the target Python version
- Verify type checker compatibility with used libraries
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Type coverage meets project thresholds
- No false positive type errors from strict checking
- Protocol classes properly describe interfaces
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Python community best practices

## Integration Points

- **Companion Agent**: `@python-type-checker` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Python coverage |
<!-- Technology knowledge base entry for Python Type Checker in Python Backend -->