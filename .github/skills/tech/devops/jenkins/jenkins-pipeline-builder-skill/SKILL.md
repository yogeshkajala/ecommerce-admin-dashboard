---
description: "Jenkins Pipeline Builder skill -- Creates Jenkins declarative and scripted pipelines for CI/CD automation with stages, parallel execution, and artifact management"
---

# Jenkins Pipeline Builder Skill

**Category:** Tech Skills > DevOps > Jenkins

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Jenkins Pipeline Builder operations using Jenkins technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Jenkins within DevOps development.

## When to Use

- When building Jenkins pipelines for CI/CD automation
- When implementing multi-branch pipeline strategies
- When configuring parallel stages for build optimization
- When Jenkins-specific technical expertise is required
- When best practices for Jenkins technology stack must be applied
- When production-grade Jenkins implementation guidance is needed

## Capabilities

- Build declarative pipelines with proper stage design
- Implement parallel stages for faster execution
- Configure post actions for notifications and cleanup
- Use pipeline steps for common CI/CD tasks
- Manage artifacts and test results

## Procedure

1. Design pipeline stages for build workflow
2. Implement Jenkinsfile with declarative syntax
3. Configure triggers and build parameters
4. Add parallel stages where appropriate
5. Implement post actions for cleanup
6. Test pipeline on feature branch

## Output Format

Return structured results:

- **Jenkinsfile**
- **Pipeline Configuration**
- **Stage Design**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Jenkins Pipeline** | Declarative pipeline syntax and patterns |
| **Parallel Stages** | Concurrent execution for speed |
| **Post Actions** | Cleanup and notification patterns |

## Anti-Hallucination Rules

- Do not use scripted pipeline unless declarative is insufficient
- Verify pipeline step availability with installed plugins
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Pipeline stages are properly ordered
- Parallel stages reduce total build time
- Post actions handle both success and failure
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Jenkins community best practices

## Integration Points

- **Companion Agent**: `@jenkins-pipeline-builder` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Jenkins coverage |
<!-- Technology knowledge base entry for Jenkins Pipeline Builder in Jenkins DevOps -->