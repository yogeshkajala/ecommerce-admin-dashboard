---
description: "Postman Environment Manager skill -- Manages Postman environments with proper variable scoping, secret handling, and environment switching for multi-stage API testing"
---

# Postman Environment Manager Skill

**Category:** Tech Skills > QA > Postman

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Postman Environment Manager operations using Postman technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Postman within QA development.

## When to Use

- When managing Postman environments for different stages
- When configuring variable scoping across environments
- When handling secrets in Postman environments
- When Postman-specific technical expertise is required
- When best practices for Postman technology stack must be applied
- When production-grade Postman implementation guidance is needed

## Capabilities

- Create environments for dev, staging, production
- Configure variable scoping and precedence
- Handle secrets with proper masking
- Implement dynamic environment variables
- Automate environment switching in CI

## Procedure

1. Design environment variable strategy
2. Create environments with proper variables
3. Configure secret variable handling
4. Test with environment switching
5. Automate in CI/CD pipeline
6. Document environment differences

## Output Format

Return structured results:

- **Environment Configuration**
- **Variable Strategy**
- **Secret Handling**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Environments** | Environment variable management |
| **Variable Scoping** | Variable precedence and overrides |
| **Secrets** | Sensitive data handling in environments |

## Anti-Hallucination Rules

- Do not commit environment files with secrets
- Verify environment features in Postman version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Environments cover all deployment stages
- Secrets are properly masked
- Variable scoping prevents conflicts
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Postman community best practices

## Integration Points

- **Companion Agent**: `@postman-environment-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Postman coverage |
<!-- Technology knowledge base entry for Postman Environment Manager in Postman QA -->
<!-- Technology knowledge base entry for Postman Environment Manager in Postman QA -->