---
description: "TypeScript Config Optimizer skill -- Optimizes TypeScript compiler configuration for project needs including strict mode, path aliases, project references, and build performance"
---

# TypeScript Config Optimizer Skill

**Category:** Tech Skills > Frontend > TypeScript

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for TypeScript Config Optimizer operations using TypeScript technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for TypeScript within Frontend development.

## When to Use

- When configuring tsconfig.json for new or existing projects
- When optimizing TypeScript build performance in large codebases
- When setting up project references for monorepo architectures
- When TypeScript-specific technical expertise is required
- When best practices for TypeScript technology stack must be applied
- When production-grade TypeScript implementation guidance is needed

## Capabilities

- Configure strict mode with appropriate strictness levels
- Set up path aliases with proper module resolution
- Implement project references for monorepo builds
- Optimize incremental builds with tsBuildInfo
- Configure declaration files and source maps

## Procedure

1. Analyze project requirements and module system
2. Configure compiler options for target environment
3. Set up path aliases and module resolution
4. Implement project references if in monorepo
5. Enable incremental compilation for performance
6. Validate configuration with sample builds

## Output Format

Return structured results:

- **TSConfig Configuration**
- **Build Performance Report**
- **Module Resolution Map**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **TSConfig Reference** | Official compiler option documentation |
| **Project References** | Monorepo build optimization with references |
| **Module Resolution** | Node, bundler, and classic resolution strategies |

## Anti-Hallucination Rules

- Do not assume compiler options are available in all TypeScript versions
- Verify module resolution strategy compatibility with bundler
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Strict mode catches potential errors
- Path aliases resolve correctly
- Build times are optimized for project size
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow TypeScript community best practices

## Integration Points

- **Companion Agent**: `@typescript-config-optimizer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full TypeScript coverage |