---
description: "Postman Test Script Writer skill -- Writes Postman test scripts with pm.test assertions for response validation, schema checking, and workflow testing"
---

# Postman Test Script Writer Skill

**Category:** Tech Skills > QA > Postman

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Postman Test Script Writer operations using Postman technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Postman within QA development.

## When to Use

- When writing test scripts for API response validation
- When implementing JSON schema validation in Postman
- When creating pre-request scripts for dynamic data
- When Postman-specific technical expertise is required
- When best practices for Postman technology stack must be applied
- When production-grade Postman implementation guidance is needed

## Capabilities

- Write pm.test assertions for responses
- Implement JSON schema validation
- Create pre-request scripts for token refresh
- Chain requests with variable extraction
- Implement custom assertion helpers

## Procedure

1. Identify test scenarios per request
2. Write response status and body assertions
3. Add JSON schema validation
4. Create pre-request scripts for setup
5. Chain requests with variable passing
6. Run collection and verify results

## Output Format

Return structured results:

- **Test Scripts**
- **Schema Definitions**
- **Pre-Request Scripts**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Test Scripts** | pm.test assertion patterns |
| **Schema Validation** | JSON schema checking in tests |
| **Pre-Request** | Dynamic data generation and auth |

## Anti-Hallucination Rules

- Do not test only status codes - validate response bodies
- Verify pm API in target Postman version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Tests cover all response scenarios
- Schema validation catches contract violations
- Pre-request scripts handle auth properly
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Postman community best practices

## Integration Points

- **Companion Agent**: `@postman-test-script-writer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Postman coverage |
<!-- Technology knowledge base entry for Postman Test Script Writer in Postman QA -->
<!-- Technology knowledge base entry for Postman Test Script Writer in Postman QA -->
<!-- Technology knowledge base entry for Postman Test Script Writer in Postman QA -->