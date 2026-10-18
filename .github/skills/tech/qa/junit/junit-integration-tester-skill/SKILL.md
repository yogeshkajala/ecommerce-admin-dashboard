---
description: "JUnit Integration Tester skill -- Implements integration tests with JUnit 5 using Testcontainers, Spring Test, and database test utilities for realistic testing"
---

# JUnit Integration Tester Skill

**Category:** Tech Skills > QA > JUnit

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for JUnit Integration Tester operations using JUnit technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for JUnit within QA development.

## When to Use

- When writing integration tests with real databases and services
- When using Testcontainers for containerized test dependencies
- When implementing Spring Boot test slices for integration testing
- When JUnit-specific technical expertise is required
- When best practices for JUnit technology stack must be applied
- When production-grade JUnit implementation guidance is needed

## Capabilities

- Configure Testcontainers for database and service tests
- Use @SpringBootTest for full context testing
- Implement test slices: @DataJpaTest, @WebMvcTest
- Configure test databases with @DynamicPropertySource
- Build reusable test fixtures with @TestConfiguration

## Procedure

1. Identify integration test boundaries
2. Configure Testcontainers for dependencies
3. Write integration tests with proper context
4. Use test slices for focused testing
5. Clean up test data between tests
6. Run in CI with proper container support

## Output Format

Return structured results:

- **Integration Tests**
- **Container Config**
- **Test Data Strategy**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Testcontainers** | Container-based integration testing |
| **Spring Test** | Spring Boot test slice patterns |
| **Test Data** | Test data management and cleanup |

## Anti-Hallucination Rules

- Do not share mutable state between integration tests
- Verify Testcontainers support in CI environment
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Integration tests use real dependencies
- Test data is cleaned between tests
- Tests run reliably in CI
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow JUnit community best practices

## Integration Points

- **Companion Agent**: `@junit-integration-tester` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full JUnit coverage |
<!-- Technology knowledge base entry for JUnit Integration Tester in JUnit QA -->
<!-- Technology knowledge base entry for JUnit Integration Tester in JUnit QA -->