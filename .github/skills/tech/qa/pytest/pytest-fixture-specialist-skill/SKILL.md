---
description: "Pytest Fixture Specialist skill -- Creates pytest fixtures for test setup and teardown with proper scoping, parameterization, and dependency injection patterns"
---

# Pytest Fixture Specialist Skill

**Category:** Tech Skills > QA > Pytest

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Pytest Fixture Specialist operations using Pytest technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Pytest within QA development.

## When to Use

- When creating pytest fixtures for test data and services
- When implementing fixture scoping for performance
- When building fixture factories for flexible test data
- When Pytest-specific technical expertise is required
- When best practices for Pytest technology stack must be applied
- When production-grade Pytest implementation guidance is needed

## Capabilities

- Create fixtures with proper scope: function, class, module, session
- Build fixture factories for configurable test data
- Implement yield fixtures for setup/teardown
- Use conftest.py for shared fixtures
- Configure autouse fixtures for implicit setup

## Procedure

1. Identify test setup requirements
2. Design fixtures with appropriate scope
3. Implement fixtures with yield for cleanup
4. Organize fixtures in conftest.py files
5. Create factories for flexible data generation
6. Test fixture interactions and dependencies

## Output Format

Return structured results:

- **Fixture Library**
- **Conftest Organization**
- **Factory Implementations**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Pytest Fixtures** | Fixture design and scoping patterns |
| **conftest.py** | Fixture sharing and organization |
| **Fixture Factories** | Configurable test data generation |

## Anti-Hallucination Rules

- Do not use session-scoped fixtures for mutable state
- Verify fixture features in target pytest version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Fixtures are scoped appropriately
- Cleanup runs even on test failure
- Factories produce valid test data
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Pytest community best practices

## Integration Points

- **Companion Agent**: `@pytest-fixture-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Pytest coverage |
<!-- Technology knowledge base entry for Pytest Fixture Specialist in Pytest QA -->
<!-- Technology knowledge base entry for Pytest Fixture Specialist in Pytest QA -->