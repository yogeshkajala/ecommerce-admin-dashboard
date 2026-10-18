---
description: "Cypress Test Writer skill -- Writes end-to-end tests with Cypress including custom commands, fixture management, and best practices for reliable test automation"
---

# Cypress Test Writer Skill

**Category:** Tech Skills > QA > Cypress

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Cypress Test Writer operations using Cypress technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Cypress within QA development.

## When to Use

- When writing E2E tests with Cypress for web applications
- When creating custom commands for test reusability
- When managing test data with fixtures and intercepts
- When Cypress-specific technical expertise is required
- When best practices for Cypress technology stack must be applied
- When production-grade Cypress implementation guidance is needed

## Capabilities

- Write Cypress tests with proper selector strategies
- Create custom commands for reusable actions
- Manage test data with fixtures and factories
- Implement intercept for API mocking
- Handle authentication in tests

## Procedure

1. Design test scenarios from user stories
2. Implement tests with proper selectors
3. Create custom commands for repeated actions
4. Set up fixtures for test data
5. Add API intercepts for isolation
6. Run in headed mode for debugging

## Output Format

Return structured results:

- **Test Suite**
- **Custom Commands**
- **Fixture Library**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Cypress Best Practices** | Official testing anti-patterns and recommendations |
| **Custom Commands** | Reusable command patterns |
| **Test Isolation** | Independent test design principles |

## Anti-Hallucination Rules

- Do not use cy.wait with arbitrary timeouts
- Verify Cypress command availability in target version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Tests are independent and can run in any order
- Custom commands improve readability
- Intercepts match actual API contracts
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Cypress community best practices

## Integration Points

- **Companion Agent**: `@cypress-test-writer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Cypress coverage |
<!-- Technology knowledge base entry for Cypress Test Writer in Cypress QA -->
<!-- Technology knowledge base entry for Cypress Test Writer in Cypress QA -->