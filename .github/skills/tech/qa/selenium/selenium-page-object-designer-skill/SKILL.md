---
description: "Selenium Page Object Designer skill -- Designs Page Object Model patterns for Selenium tests with proper abstraction, component objects, and fluent API design"
---

# Selenium Page Object Designer Skill

**Category:** Tech Skills > QA > Selenium

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Selenium Page Object Designer operations using Selenium technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Selenium within QA development.

## When to Use

- When implementing Page Object Model for test maintainability
- When creating reusable component objects for UI elements
- When designing fluent APIs for test readability
- When Selenium-specific technical expertise is required
- When best practices for Selenium technology stack must be applied
- When production-grade Selenium implementation guidance is needed

## Capabilities

- Design Page Object classes with proper encapsulation
- Create component objects for reusable UI elements
- Implement fluent API for readable test code
- Build page factory patterns for lazy initialization
- Design base page class with common functionality

## Procedure

1. Analyze UI structure for page boundaries
2. Design page objects with proper methods
3. Create component objects for repeated elements
4. Implement fluent method chaining
5. Add base page with common utilities
6. Test page objects work across scenarios

## Output Format

Return structured results:

- **Page Object Design**
- **Component Library**
- **API Documentation**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Page Object Model** | POM design patterns and best practices |
| **Component Objects** | Reusable UI component abstraction |
| **Fluent API** | Readable test method chaining |

## Anti-Hallucination Rules

- Do not put assertions inside page objects
- Verify page object patterns match the test framework
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Page objects abstract implementation details
- Components are reusable across pages
- Method names describe user actions
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Selenium community best practices

## Integration Points

- **Companion Agent**: `@selenium-page-object-designer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Selenium coverage |
<!-- Technology knowledge base entry for Selenium Page Object Designer in Selenium QA -->