---
description: "JUnit Extension Developer skill -- Creates JUnit 5 extensions for cross-cutting test concerns including test lifecycle callbacks, parameter resolution, and condition evaluation"
---

# JUnit Extension Developer Skill

**Category:** Tech Skills > QA > JUnit

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for JUnit Extension Developer operations using JUnit technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for JUnit within QA development.

## When to Use

- When building custom JUnit 5 extensions for shared test logic
- When implementing parameter resolvers for dependency injection
- When creating execution conditions for conditional test execution
- When JUnit-specific technical expertise is required
- When best practices for JUnit technology stack must be applied
- When production-grade JUnit implementation guidance is needed

## Capabilities

- Build lifecycle callback extensions
- Implement ParameterResolver for test DI
- Create ExecutionCondition for conditional tests
- Design TestWatcher for test result handling
- Build composite extensions with @ExtendWith

## Procedure

1. Identify cross-cutting test concerns
2. Design extension with proper callbacks
3. Implement extension interface methods
4. Register with @ExtendWith or auto-detection
5. Test extension behavior
6. Document extension usage

## Output Format

Return structured results:

- **Extension Implementation**
- **Registration Config**
- **Usage Documentation**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **JUnit Extensions** | Extension model and callback lifecycle |
| **ParameterResolver** | Dependency injection in tests |
| **ExecutionCondition** | Conditional test execution patterns |

## Anti-Hallucination Rules

- Do not modify test state from lifecycle callbacks without documentation
- Verify extension API in target JUnit version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Extensions do not interfere with test isolation
- Parameter resolvers provide correct instances
- Conditions evaluate correctly
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow JUnit community best practices

## Integration Points

- **Companion Agent**: `@junit-extension-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full JUnit coverage |
<!-- Technology knowledge base entry for JUnit Extension Developer in JUnit QA -->