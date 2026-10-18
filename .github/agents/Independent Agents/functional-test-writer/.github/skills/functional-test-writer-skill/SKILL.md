---
name: functional-test-writer-skill
description: "Functional Test Writer skill -- Generate functional and integration tests: E2E scenarios, BDD features, API tests, and acceptance criteria validation."
---
# Functional Test Writer Skill

## Purpose
Provides domain knowledge for writing functional and integration tests: E2E user workflows, BDD features, API integration tests, and acceptance criteria validation.

## When to Use
- When writing end-to-end tests that validate complete user workflows
- When creating BDD scenarios (Given/When/Then) from acceptance criteria
- When writing API integration tests that validate endpoint contracts
- When validating that acceptance criteria are met through automated tests

## Capabilities
- Design E2E test scenarios covering complete user journeys
- Generate BDD feature files from acceptance criteria
- Write API integration tests validating request/response contracts
- Create test fixtures with realistic data mirroring production patterns
- Validate error paths, boundary conditions, and concurrency scenarios
- Isolate external dependencies with controlled test doubles
- Follow Arrange-Act-Assert pattern with clear phase separation
- Produce structured test reports with pass/fail and coverage metrics

## Procedure
1. Receive test request -- identify feature, endpoints, or user workflows to cover
2. Analyze acceptance criteria to derive functional test scenarios
3. Design E2E scenarios covering happy path, error paths, and edge cases
4. Create test fixtures and realistic test data (no PII or production data)
5. Write functional tests following Arrange-Act-Assert pattern
6. Classify failures -- differentiate between defects, environment issues, and flaky tests
7. Calculate coverage metrics -- statement, branch, path coverage against quality gates
8. Generate test report with results summary, coverage metrics, defect list, and recommendations

## Output Format
Return structured results:
- **Test Summary**: total, passed, failed, skipped, blocked counts
- **Coverage Metrics**: statement, branch, and path coverage percentages
- **Defect List**: ID, severity, description, steps to reproduce, expected vs actual
- **Risk Assessment**: untested areas, coverage gaps, and risk-based recommendations
- **Quality Gate**: PASS/FAIL with gate criteria evaluation details

## Industry Standards
| Standard | Relevance |
|----------|-----------|
| **ISTQB Foundation** | Test design techniques, test levels, and test process framework |
| **ISO 25010** | Software quality model -- functional suitability, reliability, usability |
| **OWASP Testing Guide** | Security testing methodology for web applications |

## Anti-Hallucination Rules
- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER report test results without actual test execution evidence
- ALWAYS distinguish between tested and untested code paths
