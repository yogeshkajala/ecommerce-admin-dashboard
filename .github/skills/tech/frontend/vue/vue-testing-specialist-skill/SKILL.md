---
description: "Vue Testing Specialist skill -- Writes comprehensive tests for Vue applications using Vue Test Utils, Vitest, and component testing with proper mocking strategies"
---

# Vue Testing Specialist Skill

**Category:** Tech Skills > Frontend > Vue

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Vue Testing Specialist operations using Vue technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Vue within Frontend development.

## When to Use

- When writing component tests with Vue Test Utils
- When setting up Vitest for Vue component testing
- When testing Pinia stores and composables in isolation
- When Vue-specific technical expertise is required
- When best practices for Vue technology stack must be applied
- When production-grade Vue implementation guidance is needed

## Capabilities

- Mount components with Vue Test Utils and proper stubs
- Test composables with renderComposable patterns
- Mock Pinia stores for component testing
- Test async components and Suspense boundaries
- Configure Vitest with Vue plugin for SFC testing

## Procedure

1. Identify test scenarios from component specifications
2. Configure test environment with Vue Test Utils
3. Write component tests with proper mounting options
4. Mock dependencies including stores and router
5. Test async operations and reactive updates
6. Verify coverage meets project thresholds

## Output Format

Return structured results:

- **Test Suite**
- **Mock Configuration**
- **Coverage Report**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Vue Test Utils** | Official testing utility API and patterns |
| **Vitest** | Test runner configuration for Vue SFC testing |
| **Component Testing** | Mount vs shallow mount strategies |

## Anti-Hallucination Rules

- Do not use deprecated Vue Test Utils v1 APIs with Vue 3
- Verify test utility version matches Vue version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Tests are isolated and independent
- Async updates use nextTick or flushPromises
- Store mocks reset between tests
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Vue community best practices

## Integration Points

- **Companion Agent**: `@vue-testing-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Vue coverage |
<!-- Technology knowledge base entry for Vue Testing Specialist in Vue Frontend -->