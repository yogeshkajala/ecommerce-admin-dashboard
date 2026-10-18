---
description: "Jenkins Migration Specialist skill -- Plans and executes Jenkins migrations including version upgrades, plugin migration, and pipeline modernization to declarative syntax"
---

# Jenkins Migration Specialist Skill

**Category:** Tech Skills > DevOps > Jenkins

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Jenkins Migration Specialist operations using Jenkins technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Jenkins within DevOps development.

## When to Use

- When upgrading Jenkins to new LTS versions
- When migrating from freestyle jobs to declarative pipelines
- When moving Jenkins to containerized deployment
- When Jenkins-specific technical expertise is required
- When best practices for Jenkins technology stack must be applied
- When production-grade Jenkins implementation guidance is needed

## Capabilities

- Plan Jenkins major version upgrades
- Migrate freestyle jobs to pipeline as code
- Convert scripted to declarative pipelines
- Containerize Jenkins with proper persistence
- Implement Configuration as Code for reproducibility

## Procedure

1. Assess current Jenkins configuration and jobs
2. Plan migration with compatibility checks
3. Test upgrade on staging instance
4. Migrate jobs to pipeline as code
5. Implement JCasC for configuration
6. Validate all pipelines work post-migration

## Output Format

Return structured results:

- **Migration Plan**
- **Compatibility Report**
- **Validation Results**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Jenkins Upgrade** | LTS upgrade procedures and compatibility |
| **Pipeline Migration** | Converting freestyle to pipeline jobs |
| **JCasC** | Configuration as Code for Jenkins |

## Anti-Hallucination Rules

- Do not skip staging testing for Jenkins upgrades
- Verify plugin compatibility before upgrading
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- All pipelines work after migration
- No data loss during upgrade
- Configuration is reproducible with JCasC
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Jenkins community best practices

## Integration Points

- **Companion Agent**: `@jenkins-migration-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Jenkins coverage |
<!-- Technology knowledge base entry for Jenkins Migration Specialist in Jenkins DevOps -->
<!-- Technology knowledge base entry for Jenkins Migration Specialist in Jenkins DevOps -->