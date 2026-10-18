---
description: "Selenium Wait Strategy Specialist skill -- Implements advanced wait strategies for Selenium tests including custom expected conditions, polling, and timeout management"
---

# Selenium Wait Strategy Specialist Skill

**Category:** Tech Skills > QA > Selenium

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Selenium Wait Strategy Specialist operations using Selenium technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Selenium within QA development.

## When to Use

- When handling dynamic page loads and AJAX requests
- When implementing custom wait conditions for complex scenarios
- When debugging flaky tests caused by timing issues
- When Selenium-specific technical expertise is required
- When best practices for Selenium technology stack must be applied
- When production-grade Selenium implementation guidance is needed

## Capabilities

- Implement explicit waits with WebDriverWait
- Create custom ExpectedConditions for complex scenarios
- Configure FluentWait with polling intervals
- Handle AJAX completion with JavaScript execution
- Design retry mechanisms for intermittent failures

## Procedure

1. Analyze page loading patterns and AJAX calls
2. Design wait strategy for each interaction type
3. Implement custom conditions for complex waits
4. Configure timeouts and polling intervals
5. Replace implicit waits with explicit waits
6. Validate wait strategies eliminate flakiness

## Output Format

Return structured results:

- **Wait Strategy**
- **Custom Conditions**
- **Timeout Configuration**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Explicit Waits** | WebDriverWait and ExpectedConditions |
| **Fluent Waits** | Configurable polling and timeout |
| **AJAX Handling** | Waiting for async operations to complete |

## Anti-Hallucination Rules

- Do not use implicit waits alongside explicit waits
- Verify wait API in target Selenium version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Tests are not flaky due to timing
- Wait timeouts are reasonable
- Custom conditions handle edge cases
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Selenium community best practices

## Integration Points

- **Companion Agent**: `@selenium-wait-strategy-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Selenium coverage |
<!-- Technology knowledge base entry for Selenium Wait Strategy Specialist in Selenium QA -->