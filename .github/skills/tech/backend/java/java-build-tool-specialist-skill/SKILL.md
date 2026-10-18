---
description: "Java Build Tool Specialist skill -- Configures and optimizes Java build systems with Maven and Gradle including dependency management, multi-module builds, and build caching"
---

# Java Build Tool Specialist Skill

**Category:** Tech Skills > Backend > Java

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Java Build Tool Specialist operations using Java technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Java within Backend development.

## When to Use

- When setting up Maven or Gradle build configurations
- When optimizing build times with caching and parallel execution
- When managing dependencies and resolving conflicts in multi-module projects
- When Java-specific technical expertise is required
- When best practices for Java technology stack must be applied
- When production-grade Java implementation guidance is needed

## Capabilities

- Configure Maven POM with proper dependency management
- Set up Gradle builds with Kotlin DSL
- Implement multi-module build structures
- Configure build caching for faster incremental builds
- Manage dependency versions with BOM and platform dependencies

## Procedure

1. Analyze project structure and build requirements
2. Choose and configure build tool
3. Set up dependency management strategy
4. Configure multi-module build if needed
5. Optimize build performance with caching
6. Validate build reproducibility

## Output Format

Return structured results:

- **Build Configuration**
- **Dependency Analysis**
- **Performance Report**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Maven Central** | Maven repository and dependency management |
| **Gradle Best Practices** | Gradle build optimization and conventions |
| **Reproducible Builds** | Ensuring build output consistency |

## Anti-Hallucination Rules

- Do not assume Gradle plugin compatibility without checking
- Verify Maven plugin versions match the target Java version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Dependencies have no version conflicts
- Build times are optimized with caching
- Multi-module builds respect dependency order
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Java community best practices

## Integration Points

- **Companion Agent**: `@java-build-tool-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Java coverage |