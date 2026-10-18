---
description: "Api Tester skill -- Test API contracts: request/response validation, error handling, pagination, auth."
---
# Api Tester Skill

## Purpose
Provides domain-specific knowledge and step-by-step procedures for Api Tester operations.

## When to Use
- When performing testing tasks that require specialized knowledge
- When structured output and validated results are needed
- When domain best practices and industry standards must be applied

## Capabilities
- Design and execute comprehensive test strategies aligned with project requirements
- Generate test cases covering positive, negative, boundary, and edge scenarios
- Validate test coverage metrics against quality gates and thresholds
- Identify test gaps through risk-based analysis and requirement traceability
- Evaluate test results and classify failures as defects, environment issues, or flaky tests
- Integrate with CI/CD pipelines for automated test execution and reporting
- Apply testing frameworks (xUnit, pytest, Jest, Cypress) per technology stack
- Produce structured test reports with pass/fail metrics and trend analysis

## Procedure
1. Receive test request -- identify scope, test type (unit, integration, e2e, performance), and target components
2. Analyze requirements and acceptance criteria to derive test conditions and expected behaviors
3. Design test cases covering positive flows, negative paths, boundary values, and error handling
4. Map test cases to requirements for traceability and coverage verification
5. Execute tests against target environment -- collect pass/fail results with evidence
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
