---
description: "Java GraalVM Specialist skill -- Builds native Java applications with GraalVM Native Image including ahead-of-time compilation, reflection configuration, and startup optimization"
---

# Java GraalVM Specialist Skill

**Category:** Tech Skills > Backend > Java

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Java GraalVM Specialist operations using Java technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Java within Backend development.

## When to Use

- When compiling Java applications to native executables
- When optimizing startup time and memory footprint
- When configuring GraalVM for serverless and container deployments
- When Java-specific technical expertise is required
- When best practices for Java technology stack must be applied
- When production-grade Java implementation guidance is needed

## Capabilities

- Compile Java applications with GraalVM Native Image
- Configure reflection, serialization, and resource hints
- Optimize native image size and startup time
- Handle dynamic features with tracing agent
- Build container images with native executables

## Procedure

1. Assess application suitability for native compilation
2. Configure native image build with Maven/Gradle plugins
3. Run tracing agent to discover dynamic features
4. Resolve reflection and resource configuration
5. Optimize image size and startup
6. Test native executable against JVM behavior

## Output Format

Return structured results:

- **Native Image Configuration**
- **Reflection Config**
- **Startup Benchmarks**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **GraalVM Native Image** | Ahead-of-time compilation configuration and limitations |
| **Spring Native** | Spring Boot native image support and hints |
| **Quarkus Native** | Quarkus native build best practices |

## Anti-Hallucination Rules

- Do not assume all Java libraries work with native image without testing
- Verify GraalVM version compatibility with Java version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Native executable passes all integration tests
- Startup time meets target requirements
- No missing reflection or resource configurations
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Java community best practices

## Integration Points

- **Companion Agent**: `@java-graalvm-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Java coverage |