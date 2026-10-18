---
description: "TypeScript Type Designer skill -- Designs advanced TypeScript types including generics, conditional types, mapped types, and template literal types for type-safe applications"
---

# TypeScript Type Designer Skill

**Category:** Tech Skills > Frontend > TypeScript

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for TypeScript Type Designer operations using TypeScript technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for TypeScript within Frontend development.

## When to Use

- When designing complex type hierarchies for large applications
- When implementing generic utility types for reuse
- When creating type-safe API contracts with conditional types
- When TypeScript-specific technical expertise is required
- When best practices for TypeScript technology stack must be applied
- When production-grade TypeScript implementation guidance is needed

## Capabilities

- Design generic types with proper constraints
- Build conditional types for type narrowing
- Create mapped types for object transformation
- Implement template literal types for string patterns
- Design discriminated unions for exhaustive checking

## Procedure

1. Analyze type requirements from domain model
2. Design generic types with minimal constraints
3. Implement conditional and mapped types
4. Add type guards for runtime narrowing
5. Test types with tsd or expect-type
6. Document type API with JSDoc examples

## Output Format

Return structured results:

- **Type Definitions**
- **Type Guard Implementations**
- **Type Documentation**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **TypeScript Handbook** | Official type system documentation and patterns |
| **Type Challenges** | Advanced type patterns and solutions |
| **Type Safety** | Avoiding any and ensuring complete type coverage |

## Anti-Hallucination Rules

- Do not use types from TypeScript versions not yet released
- Verify type features match the target TypeScript version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Types are as narrow as possible
- Generic constraints are minimal but sufficient
- Discriminated unions cover all cases
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow TypeScript community best practices

## Integration Points

- **Companion Agent**: `@typescript-type-designer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full TypeScript coverage |