---
description: "Pytest Parameterized Tester skill -- Implements parameterized tests with pytest.mark.parametrize including indirect parametrize, fixture parametrization, and custom IDs"
---

# Pytest Parameterized Tester Skill

**Category:** Tech Skills > QA > Pytest

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Pytest Parameterized Tester operations using Pytest technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Pytest within QA development.

## When to Use

- When creating data-driven tests with pytest parametrize
- When implementing indirect parametrization with fixtures
- When generating custom test IDs for parameterized tests
- When Pytest-specific technical expertise is required
- When best practices for Pytest technology stack must be applied
- When production-grade Pytest implementation guidance is needed

## Capabilities

- Use @pytest.mark.parametrize with multiple parameters
- Implement indirect parametrization through fixtures
- Generate custom test IDs for readability
- Combine parametrize markers for cross-product
- Load parameters from external data files

## Procedure

1. Identify parameterizable test scenarios
2. Design parameter sets with edge cases
3. Implement parametrized tests
4. Add custom IDs for identification
5. Handle parameter-specific fixtures
6. Verify all combinations pass

## Output Format

Return structured results:

- **Parameterized Tests**
- **Parameter Data**
- **Custom IDs**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Parametrize** | pytest parametrization patterns |
| **Indirect** | Indirect fixture parametrization |
| **Custom IDs** | Readable test identification |

## Anti-Hallucination Rules

- Do not create cartesian products of large parameter sets
- Verify parametrize features in target pytest version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Parameters cover boundary values
- Custom IDs identify test cases clearly
- Edge cases are included in parameters
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Pytest community best practices

## Integration Points

- **Companion Agent**: `@pytest-parameterized-tester` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Pytest coverage |
<!-- Technology knowledge base entry for Pytest Parameterized Tester in Pytest QA -->
<!-- Technology knowledge base entry for Pytest Parameterized Tester in Pytest QA -->