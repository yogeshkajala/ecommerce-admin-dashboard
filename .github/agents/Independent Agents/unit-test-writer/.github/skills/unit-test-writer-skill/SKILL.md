---
name: unit-test-writer-skill
description: "Unit Test Writer skill -- Use when writing unit tests for new feature code including happy path, edge cases, error handling, and achieving coverage targets."
---

# Unit Test Writer Skill

**Category:** Tech Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for unit test writing operations. This skill encapsulates testing patterns, mocking strategies, and coverage optimization techniques.

## When to Use

- When writing unit tests for new feature code or modules
- When covering happy path, edge cases, and error handling scenarios
- When achieving or exceeding code coverage targets (≥80%)
- When creating mocks, stubs, and test fixtures for isolated testing
- When applying parameterized or data-driven testing patterns

## Capabilities

- Analyze feature code to identify all testable units and branches
- Write tests following the Arrange-Act-Assert (AAA) pattern
- Generate test cases for happy path, edge cases, and error scenarios
- Create mock objects and test fixtures for isolated unit testing
- Calculate and optimize code coverage across lines and branches
- Detect untested code paths using static analysis techniques
- Apply parameterized testing for data-driven validation
- Produce coverage reports with gap analysis and recommendations

## Testing Patterns

| Pattern | Use Case |
|---------|----------|
| Arrange-Act-Assert | Standard unit test structure |
| Given-When-Then | BDD-style test readability |
| Parameterized Tests | Data-driven validation with multiple inputs |
| Test Doubles | Mocks, stubs, spies, fakes for isolation |
| Builder Pattern | Complex test fixture construction |
| Object Mother | Reusable test data factory |

## Procedure

1. Receive test writing request -- identify target module and coverage goals
2. Analyze the feature code to identify all public interfaces and logic branches
3. Map acceptance criteria to specific unit test scenarios
4. Write happy-path tests for each primary use case
5. Add edge case tests for boundary conditions and special inputs
6. Write error handling tests for exception paths and invalid states
7. Create mocks and fixtures to isolate units from dependencies
8. Run the test suite and analyze coverage metrics
9. Fill coverage gaps until target (≥80%) is met
10. Produce final coverage report with gap analysis

## Output Format

Return structured results:

- **Test Summary**: total tests, passing, failing, skipped counts
- **Coverage Report**: line, branch, and function coverage percentages
- **Test Categories**: happy path, edge case, error handling breakdown
- **Gap Analysis**: uncovered paths with risk assessment
- **Quality Gate**: PASS/FAIL (≥80% coverage required to pass)

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **AAA Pattern** | Arrange-Act-Assert for clear test structure |
| **FIRST Principles** | Fast, Independent, Repeatable, Self-validating, Timely |
| **Test Pyramid** | Many unit tests, fewer integration, fewest E2E |
| **Mutation Testing** | Validate test effectiveness by introducing code mutations |
