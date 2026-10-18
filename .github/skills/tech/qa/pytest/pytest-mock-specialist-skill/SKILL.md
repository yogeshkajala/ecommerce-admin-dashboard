---
description: "Pytest Mock Specialist skill -- Implements mocking strategies with pytest-mock and unittest.mock including patching, fixtures, and mock configuration"
---

# Pytest Mock Specialist Skill

**Category:** Tech Skills > QA > Pytest

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Pytest Mock Specialist operations using Pytest technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Pytest within QA development.

## When to Use

- When mocking dependencies in pytest tests
- When using pytest-mock fixture for cleaner mock syntax
- When implementing monkeypatch for environment manipulation
- When Pytest-specific technical expertise is required
- When best practices for Pytest technology stack must be applied
- When production-grade Pytest implementation guidance is needed

## Capabilities

- Mock with pytest-mock mocker fixture
- Use monkeypatch for env vars and attributes
- Implement autospec mocking for safety
- Configure mock return values and side effects
- Verify mock calls with assert_called patterns

## Procedure

1. Identify dependencies to mock
2. Choose mocker or monkeypatch approach
3. Implement mocks with proper configuration
4. Verify interactions with assertions
5. Reset mocks between tests
6. Test mock configuration correctness

## Output Format

Return structured results:

- **Mock Configuration**
- **Patch Targets**
- **Interaction Verification**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **pytest-mock** | Mocker fixture and patching patterns |
| **monkeypatch** | Environment and attribute manipulation |
| **autospec** | Spec-based mock safety |

## Anti-Hallucination Rules

- Do not mock too many dependencies - test real behavior where possible
- Verify mock features in target pytest-mock version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Mocks use autospec for safety
- Interactions are verified not just return values
- Monkeypatch changes are scoped to tests
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Pytest community best practices

## Integration Points

- **Companion Agent**: `@pytest-mock-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Pytest coverage |
<!-- Technology knowledge base entry for Pytest Mock Specialist in Pytest QA -->
<!-- Technology knowledge base entry for Pytest Mock Specialist in Pytest QA -->
<!-- Technology knowledge base entry for Pytest Mock Specialist in Pytest QA -->