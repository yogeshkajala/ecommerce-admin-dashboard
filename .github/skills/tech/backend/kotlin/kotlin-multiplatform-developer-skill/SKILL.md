---
description: "Kotlin Multiplatform Developer skill -- Builds cross-platform applications with Kotlin Multiplatform sharing business logic across Android, iOS, web, and desktop targets"
---

# Kotlin Multiplatform Developer Skill

**Category:** Tech Skills > Backend > Kotlin

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Kotlin Multiplatform Developer operations using Kotlin technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Kotlin within Backend development.

## When to Use

- When sharing business logic across platforms with KMP
- When implementing expect/actual declarations for platform specifics
- When configuring Kotlin Multiplatform project structure
- When Kotlin-specific technical expertise is required
- When best practices for Kotlin technology stack must be applied
- When production-grade Kotlin implementation guidance is needed

## Capabilities

- Configure KMP project with shared and platform modules
- Implement expect/actual for platform-specific code
- Share business logic and data models across targets
- Configure serialization with kotlinx.serialization
- Build UI with Compose Multiplatform for shared UI

## Procedure

1. Design module structure for code sharing
2. Implement shared business logic in commonMain
3. Add platform-specific implementations with expect/actual
4. Configure build targets and dependencies
5. Test shared code with common test infrastructure
6. Build platform-specific artifacts

## Output Format

Return structured results:

- **Project Structure**
- **Shared Module**
- **Platform Configurations**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **KMP** | Kotlin Multiplatform project structure and patterns |
| **Compose Multiplatform** | Shared UI across platforms |
| **kotlinx.serialization** | Multiplatform serialization library |

## Anti-Hallucination Rules

- Do not assume all Kotlin stdlib functions work on all targets
- Verify KMP plugin version compatibility across targets
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Shared code compiles on all target platforms
- Platform-specific code is minimized
- Tests run on all target platforms
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Kotlin community best practices

## Integration Points

- **Companion Agent**: `@kotlin-multiplatform-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Kotlin coverage |