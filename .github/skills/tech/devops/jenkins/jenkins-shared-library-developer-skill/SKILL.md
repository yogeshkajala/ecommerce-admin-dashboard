---
description: "Jenkins Shared Library Developer skill -- Creates Jenkins shared libraries for reusable pipeline code with custom steps, global variables, and proper testing"
---

# Jenkins Shared Library Developer Skill

**Category:** Tech Skills > DevOps > Jenkins

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Jenkins Shared Library Developer operations using Jenkins technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Jenkins within DevOps development.

## When to Use

- When building reusable pipeline code as shared libraries
- When creating custom pipeline steps for standardization
- When testing shared library code with unit tests
- When Jenkins-specific technical expertise is required
- When best practices for Jenkins technology stack must be applied
- When production-grade Jenkins implementation guidance is needed

## Capabilities

- Create shared libraries with proper structure
- Implement custom pipeline steps as vars
- Build class-based shared library code in src
- Test library code with JenkinsPipelineUnit
- Configure library loading in Jenkins

## Procedure

1. Design library structure and API
2. Implement custom steps in vars directory
3. Create utility classes in src directory
4. Write unit tests with JenkinsPipelineUnit
5. Configure library in Jenkins management
6. Document step usage and parameters

## Output Format

Return structured results:

- **Library Implementation**
- **Custom Steps**
- **Test Suite**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Shared Libraries** | Library structure and loading patterns |
| **Custom Steps** | Pipeline step development conventions |
| **Testing** | JenkinsPipelineUnit testing patterns |

## Anti-Hallucination Rules

- Do not use @NonCPS annotation without understanding implications
- Verify shared library features in target Jenkins version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Library steps are well-documented
- Unit tests cover all custom steps
- Library loads correctly in pipelines
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Jenkins community best practices

## Integration Points

- **Companion Agent**: `@jenkins-shared-library-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Jenkins coverage |
<!-- Technology knowledge base entry for Jenkins Shared Library Developer in Jenkins DevOps -->