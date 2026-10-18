---
applyTo: "**/*test*"
---

# Testing Standards

## Convention Discovery (do this FIRST)
Before writing tests, read existing test files and project config to discover:
- Test framework (pytest, jest, mocha, etc.)
- Test runner and assertion patterns
- How the app is instantiated for testing (test client, ASGI transport, supertest, etc.)
- How auth is handled in tests (token generation, test users)
- Database setup/teardown patterns (fresh DB per test, transactions, fixtures)
- Any OS-specific issues (e.g., file lock cleanup on Windows)

## Structure
- Follow Arrange-Act-Assert (AAA) pattern for all tests
- One assertion concept per test method
- Test file mirrors source file path: `src/foo/bar.py` → `tests/foo/test_bar.py`

## Naming
- Test functions: `test_<method>_<scenario>_<expected_result>`
- Test classes: `Test<ClassName>`
- Fixtures: descriptive names matching the data they represent

## Coverage
- Minimum 80% line coverage required to pass quality gate
- Minimum 70% branch coverage required
- Critical paths (auth, payments, data mutations) require 100% coverage

## Mocking
- Only mock external dependencies (DB, APIs, file system)
- Never mock the unit under test
- Prefer fakes over mocks when possible for better test confidence
- Reset all mocks/patches in teardown

## Test Categories
- Unit tests: fast, isolated, no I/O
- Integration tests: test component interactions, may use test containers
- E2E tests: full user workflows, run against staging-like environment

## Anti-Patterns (NEVER do)
- Tests that pass trivially without exercising real logic
- Tests that depend on execution order
- Tests with sleep/wait instead of proper async handling
- Commented-out or skipped tests without a tracking ticket
