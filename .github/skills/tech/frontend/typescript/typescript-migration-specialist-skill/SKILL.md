---
description: "TypeScript Migration Specialist skill -- Plans and executes JavaScript to TypeScript migrations with incremental adoption, type definition strategies, and build system integration"
---

# TypeScript Migration Specialist Skill

**Category:** Tech Skills > Frontend > TypeScript

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for TypeScript Migration Specialist operations using TypeScript technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for TypeScript within Frontend development.

## When to Use

- When migrating JavaScript codebases to TypeScript
- When implementing incremental TypeScript adoption strategies
- When resolving type errors during migration
- When TypeScript-specific technical expertise is required
- When best practices for TypeScript technology stack must be applied
- When production-grade TypeScript implementation guidance is needed

## Capabilities

- Plan phased migration from JavaScript to TypeScript
- Configure allowJs for incremental adoption
- Generate type definitions for existing JavaScript modules
- Resolve common migration type errors
- Set up declaration files for third-party libraries

## Procedure

1. Assess codebase size and complexity for migration
2. Configure TypeScript with allowJs and checkJs
3. Prioritize files for migration by dependency order
4. Convert files with proper type annotations
5. Resolve type errors incrementally
6. Validate migrated code with tests

## Output Format

Return structured results:

- **Migration Plan**
- **Configuration Changes**
- **Type Error Resolution**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Migration Guide** | Official JavaScript to TypeScript migration patterns |
| **Incremental Adoption** | allowJs and checkJs for gradual migration |
| **DefinitelyTyped** | Type definitions for third-party packages |

## Anti-Hallucination Rules

- Do not assume all JavaScript patterns have direct TypeScript equivalents
- Verify type definition availability for third-party packages
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Migration preserves runtime behavior
- Type coverage increases with each phase
- No any types are introduced without justification
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow TypeScript community best practices

## Integration Points

- **Companion Agent**: `@typescript-migration-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full TypeScript coverage |