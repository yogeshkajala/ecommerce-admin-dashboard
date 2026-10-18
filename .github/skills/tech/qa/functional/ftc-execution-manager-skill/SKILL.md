---
description: "Ftc Execution Manager skill -- Track test execution: run tests, record results, calculate coverage, and report metrics."
---

# Ftc Execution Manager Skill

**Category:** Tech Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Ftc Execution Manager operations. This skill encapsulates technology-specific patterns, toolchain expertise, and implementation best practices.

## When to Use

- When Track test execution: run tests, record results, calculate coverage, and report metrics
- When technology-specific patterns and toolchain expertise are required
- When automated scanning, analysis, or code generation is needed
- When integration with development tools and CI/CD pipelines is required

## Capabilities

- Design and execute comprehensive test strategies aligned with project requirements
- Generate test cases covering positive, negative, boundary, and edge scenarios
- Configure and run test frameworks: Jest, pytest, JUnit, xUnit, NUnit, Cypress, Playwright
- Create mock objects, stubs, and fixtures for external dependency isolation
- Measure code coverage (line, branch, function) and identify untested paths
- Detect and isolate flaky tests through retry analysis and environment profiling
- Generate parameterized tests for input variation coverage
- Produce structured test reports with pass/fail metrics and trend analysis

## Procedure

1. Receive test request -- identify scope, test type (unit, integration, e2e, performance), and target components
2. Detect project language, framework, and test runner from project configuration files
3. Analyze source code to identify testable units, boundaries, and dependencies requiring mocks
4. Generate test cases covering positive flows, negative paths, boundary values, and error handling
5. Configure test execution environment with required dependencies and test data
6. Execute tests with coverage instrumentation -- collect pass/fail results with evidence
7. Analyze failures -- categorize as real defects, environment issues, or flaky tests
8. Calculate coverage metrics (line, branch, function) and compare against quality gates
9. Generate structured test report with results, coverage, defect list, and recommendations

## Output Format

Return structured results:

- **Summary**: operation performed, scope, and execution status
- **Findings**: issue ID, severity, file/location, description, remediation
- **Metrics**: quantitative measurements (coverage, complexity, performance, counts)
- **Quality Gate**: PASS/FAIL with gate criteria evaluation details
- **Recommendations**: prioritized improvement actions with effort estimates

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **IEEE 730** | Software quality assurance processes and standards |
| **ISO 25010** | Software quality model: functional suitability, reliability, maintainability |

## Anti-Hallucination Rules

- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER report tool output without actual execution evidence
- ALWAYS verify version compatibility before applying technology-specific patterns

## Constraints

- NEVER execute destructive operations without explicit user confirmation
- NEVER store, log, or expose secrets, credentials, or PII in output
- ALWAYS provide evidence for assertions -- no claims without supporting data
- ALWAYS follow the principle of least privilege for tool and data access
- NEVER bypass security checks or disable safety validations
- ALWAYS use the appropriate tool version matching the target environment
