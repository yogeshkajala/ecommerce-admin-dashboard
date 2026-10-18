---
description: "Cypress Plugin Developer skill -- Creates Cypress plugins for extending framework capabilities with custom tasks, preprocessors, and event handlers"
---

# Cypress Plugin Developer Skill

**Category:** Tech Skills > QA > Cypress

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Cypress Plugin Developer operations using Cypress technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Cypress within QA development.

## When to Use

- When extending Cypress with custom plugins
- When implementing task handlers for Node.js operations
- When creating preprocessors for test file handling
- When Cypress-specific technical expertise is required
- When best practices for Cypress technology stack must be applied
- When production-grade Cypress implementation guidance is needed

## Capabilities

- Build plugins with setupNodeEvents
- Implement custom cy.task handlers
- Create preprocessors for TypeScript and bundling
- Design browser launch handlers
- Configure environment-specific plugin logic

## Procedure

1. Identify extension requirements
2. Implement plugin in cypress.config
3. Create task handlers for Node operations
4. Configure preprocessors if needed
5. Test plugin functionality
6. Document plugin configuration

## Output Format

Return structured results:

- **Plugin Implementation**
- **Task Handlers**
- **Configuration**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Cypress Plugins** | Plugin API and event handlers |
| **Tasks** | Node.js task execution from tests |
| **Preprocessors** | Test file compilation and bundling |

## Anti-Hallucination Rules

- Do not perform browser operations in tasks - use commands instead
- Verify plugin API in target Cypress version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Plugins work in both headed and headless modes
- Tasks handle errors gracefully
- Configuration is documented
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Cypress community best practices

## Integration Points

- **Companion Agent**: `@cypress-plugin-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Cypress coverage |
<!-- Technology knowledge base entry for Cypress Plugin Developer in Cypress QA -->
<!-- Technology knowledge base entry for Cypress Plugin Developer in Cypress QA -->
<!-- Technology knowledge base entry for Cypress Plugin Developer in Cypress QA -->