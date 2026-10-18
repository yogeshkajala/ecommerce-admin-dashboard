---
description: "Selenium WebDriver Specialist skill -- Implements browser automation with Selenium WebDriver including element interaction, wait strategies, and cross-browser testing"
---

# Selenium WebDriver Specialist Skill

**Category:** Tech Skills > QA > Selenium

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Selenium WebDriver Specialist operations using Selenium technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Selenium within QA development.

## When to Use

- When building automated browser tests with Selenium WebDriver
- When implementing explicit and implicit wait strategies
- When handling dynamic web elements and iframes
- When Selenium-specific technical expertise is required
- When best practices for Selenium technology stack must be applied
- When production-grade Selenium implementation guidance is needed

## Capabilities

- Implement WebDriver for Chrome, Firefox, Edge, Safari
- Design explicit wait strategies with ExpectedConditions
- Handle dynamic elements, iframes, and shadow DOM
- Configure WebDriver options for headless and mobile emulation
- Implement screenshot capture and video recording

## Procedure

1. Set up WebDriver with proper browser configuration
2. Design locator strategies with CSS and XPath
3. Implement wait strategies for dynamic elements
4. Handle alerts, frames, and multiple windows
5. Add screenshot on failure for debugging
6. Run tests across target browsers

## Output Format

Return structured results:

- **Test Implementation**
- **Wait Configuration**
- **Browser Matrix**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Selenium WebDriver** | W3C WebDriver protocol implementation |
| **Wait Strategies** | Explicit vs implicit wait best practices |
| **Locator Strategies** | CSS selector and XPath design patterns |

## Anti-Hallucination Rules

- Do not use Thread.sleep for synchronization
- Verify WebDriver compatibility with browser versions
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Tests use explicit waits for reliability
- Locators are resilient to UI changes
- Tests run on all target browsers
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Selenium community best practices

## Integration Points

- **Companion Agent**: `@selenium-webdriver-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Selenium coverage |