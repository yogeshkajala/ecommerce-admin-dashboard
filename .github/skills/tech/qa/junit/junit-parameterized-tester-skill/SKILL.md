---
description: "JUnit Parameterized Tester skill -- Creates parameterized tests with JUnit 5 using @ParameterizedTest, various sources, and custom argument converters"
---

# JUnit Parameterized Tester Skill

**Category:** Tech Skills > QA > JUnit

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for JUnit Parameterized Tester operations using JUnit technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for JUnit within QA development.

## When to Use

- When testing methods with multiple input combinations
- When implementing data-driven tests with external sources
- When creating custom argument providers for complex scenarios
- When JUnit-specific technical expertise is required
- When best practices for JUnit technology stack must be applied
- When production-grade JUnit implementation guidance is needed

## Capabilities

- Write parameterized tests with @ValueSource, @CsvSource
- Implement @MethodSource for complex parameters
- Create custom ArgumentsProvider implementations
- Use @CsvFileSource for external test data
- Implement custom argument converters

## Procedure

1. Identify parameterizable test scenarios
2. Choose appropriate parameter source
3. Implement parameterized test
4. Add display name generation
5. Handle edge case parameters
6. Verify all parameter combinations pass

## Output Format

Return structured results:

- **Parameterized Tests**
- **Argument Sources**
- **Edge Cases**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Parameterized Tests** | JUnit 5 parameterized test patterns |
| **Argument Sources** | Built-in and custom argument providers |
| **Display Names** | Readable test names for parameterized tests |

## Anti-Hallucination Rules

- Do not create excessive parameter combinations
- Verify parameterized test features in JUnit version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Parameters cover boundary values
- Display names identify the test case
- Custom providers are reusable
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow JUnit community best practices

## Integration Points

- **Companion Agent**: `@junit-parameterized-tester` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full JUnit coverage |
<!-- Technology knowledge base entry for JUnit Parameterized Tester in JUnit QA -->
<!-- Technology knowledge base entry for JUnit Parameterized Tester in JUnit QA -->