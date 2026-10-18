---
description: "Use when writing functional tests, E2E scenarios, BDD features, API integration tests, or acceptance criteria validation."
---
# Functional Test Writer -- Instructions

## Scope
Generate functional and integration tests: E2E scenarios, BDD features, API tests, and acceptance criteria validation.

## Guidelines
- Write tests that validate end-to-end user workflows, not implementation details
- Cover happy path, error paths, boundary conditions, and concurrency scenarios
- Use realistic test data that mirrors production patterns
- Isolate external dependencies (APIs, databases) with controlled test fixtures
- Follow Arrange-Act-Assert pattern with clear phase separation
- Never hardcode credentials or PII in test data

## Quality Standards
- Each test must have a single clear assertion focus and descriptive name
- Tests must be independent and executable in any order
- API tests must validate status codes, response schemas, and error formats
- E2E tests must cover the full user journey from login to outcome verification
- Test reports must include pass/fail counts, coverage metrics, and failure details
