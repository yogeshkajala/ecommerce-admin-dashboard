---
description: "Vue Composition Specialist skill -- Creates and organizes Vue composables for reusable logic extraction, dependency injection, and cross-component state sharing"
---

# Vue Composition Specialist Skill

**Category:** Tech Skills > Frontend > Vue

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Vue Composition Specialist operations using Vue technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Vue within Frontend development.

## When to Use

- When extracting reusable logic into Vue composables
- When organizing complex component logic with composition functions
- When implementing VueUse-style utility composables
- When Vue-specific technical expertise is required
- When best practices for Vue technology stack must be applied
- When production-grade Vue implementation guidance is needed

## Capabilities

- Build custom composables with reactive state and lifecycle hooks
- Implement dependency injection with provide/inject in composables
- Create composable factories with configuration options
- Design composable APIs following VueUse conventions
- Handle cleanup and disposal in composable lifecycle

## Procedure

1. Identify reusable logic across components
2. Design composable API with input/output contract
3. Implement composable with reactive references
4. Add lifecycle hooks and cleanup logic
5. Test composable with Vue Test Utils composable testing
6. Document composable usage and constraints

## Output Format

Return structured results:

- **Composable Implementation**
- **API Documentation**
- **Test Suite**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Composable Conventions** | use* naming and return value patterns from VueUse |
| **Reactivity API** | ref, reactive, computed, watch patterns |
| **Lifecycle Integration** | Proper lifecycle hook usage in composables |

## Anti-Hallucination Rules

- Do not assume composable lifecycle hooks work outside setup()
- Verify reactivity API availability in the target Vue version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Composables follow use* naming convention
- Cleanup functions prevent memory leaks
- Reactive references are properly unwrapped
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Vue community best practices

## Integration Points

- **Companion Agent**: `@vue-composition-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Vue coverage |