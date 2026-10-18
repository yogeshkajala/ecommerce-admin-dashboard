---
description: "Selenium Cross-Browser Tester skill -- Implements cross-browser testing with Selenium across Chrome, Firefox, Edge, and Safari with capability management and browser-specific handling"
---

# Selenium Cross-Browser Tester Skill

**Category:** Tech Skills > QA > Selenium

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Selenium Cross-Browser Tester operations using Selenium technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Selenium within QA development.

## When to Use

- When testing web applications across multiple browsers
- When handling browser-specific behavior differences
- When configuring browser capabilities for testing
- When Selenium-specific technical expertise is required
- When best practices for Selenium technology stack must be applied
- When production-grade Selenium implementation guidance is needed

## Capabilities

- Configure capabilities for each target browser
- Handle browser-specific behavior differences
- Set up browser profiles with custom settings
- Implement visual comparison across browsers
- Generate cross-browser compatibility reports

## Procedure

1. Define target browser matrix
2. Configure capabilities per browser
3. Identify browser-specific behavior patterns
4. Implement browser-specific handling where needed
5. Run test suite across browser matrix
6. Generate cross-browser compatibility report

## Output Format

Return structured results:

- **Browser Matrix**
- **Capability Config**
- **Compatibility Report**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Browser Capabilities** | W3C capability configuration |
| **Cross-Browser Testing** | Browser compatibility testing patterns |
| **BrowserStack/SauceLabs** | Cloud browser testing platforms |

## Anti-Hallucination Rules

- Do not assume identical behavior across all browsers
- Verify browser support for features used
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Tests pass on all target browsers
- Browser-specific issues are documented
- Capability configuration is correct per browser
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Selenium community best practices

## Integration Points

- **Companion Agent**: `@selenium-cross-browser-tester` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Selenium coverage |
<!-- Technology knowledge base entry for Selenium Cross-Browser Tester in Selenium QA -->