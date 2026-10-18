---
description: "SonarQube Scanner Specialist skill -- Configures SonarQube scanners for different build tools and languages including Maven, Gradle, and CLI scanner with proper properties"
---

# SonarQube Scanner Specialist Skill

**Category:** Tech Skills > QA > SonarQube

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for SonarQube Scanner Specialist operations using SonarQube technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for SonarQube within QA development.

## When to Use

- When configuring SonarQube scanner for project analysis
- When integrating scanner with Maven, Gradle, or npm
- When troubleshooting scanner configuration issues
- When SonarQube-specific technical expertise is required
- When best practices for SonarQube technology stack must be applied
- When production-grade SonarQube implementation guidance is needed

## Capabilities

- Configure sonar-scanner CLI for any project
- Integrate with Maven, Gradle, and npm builds
- Set analysis properties for proper configuration
- Handle multi-module project analysis
- Optimize scanner performance for large projects

## Procedure

1. Choose appropriate scanner for build tool
2. Configure sonar-project.properties
3. Set analysis parameters
4. Integrate with build tool
5. Run initial analysis and validate
6. Optimize for performance

## Output Format

Return structured results:

- **Scanner Configuration**
- **Build Integration**
- **Analysis Properties**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **SonarScanner** | Scanner configuration and execution |
| **Analysis Properties** | Key analysis parameters |
| **Multi-Module** | Multi-module project configuration |

## Anti-Hallucination Rules

- Do not analyze generated code without exclusion patterns
- Verify scanner version compatibility with SonarQube
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Scanner analyzes all source files
- Analysis properties are correct
- Multi-module configuration works properly
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow SonarQube community best practices

## Integration Points

- **Companion Agent**: `@sonarqube-scanner-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full SonarQube coverage |
<!-- Technology knowledge base entry for SonarQube Scanner Specialist in SonarQube QA -->
<!-- Technology knowledge base entry for SonarQube Scanner Specialist in SonarQube QA -->