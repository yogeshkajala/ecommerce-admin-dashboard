---
description: "Docker Multi-Stage Builder skill -- Designs advanced multi-stage Docker builds for compiled languages with build caching, dependency management, and minimal runtime images"
---

# Docker Multi-Stage Builder Skill

**Category:** Tech Skills > DevOps > Docker

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Docker Multi-Stage Builder operations using Docker technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Docker within DevOps development.

## When to Use

- When creating minimal production images from compiled applications
- When implementing build cache optimization for large projects
- When separating build dependencies from runtime images
- When Docker-specific technical expertise is required
- When best practices for Docker technology stack must be applied
- When production-grade Docker implementation guidance is needed

## Capabilities

- Design multi-stage builds for Go, Java, Rust, .NET
- Implement BuildKit cache mounts for dependencies
- Create distroless or scratch-based runtime images
- Optimize build stages for parallelism
- Configure CI/CD cache for Docker builds

## Procedure

1. Analyze build stages and dependencies
2. Design multi-stage Dockerfile
3. Implement cache mounts for package managers
4. Create minimal runtime stage
5. Test build performance and image size
6. Configure CI/CD build caching

## Output Format

Return structured results:

- **Multi-Stage Dockerfile**
- **Build Performance**
- **Image Size Analysis**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Multi-Stage Builds** | Build optimization with multiple stages |
| **BuildKit** | Advanced build features and caching |
| **Distroless** | Minimal runtime images without shell |

## Anti-Hallucination Rules

- Do not copy build tools into runtime images
- Verify BuildKit features in target Docker version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Runtime image contains only necessary files
- Build cache reduces rebuild times significantly
- Image size is minimized for production
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Docker community best practices

## Integration Points

- **Companion Agent**: `@docker-multi-stage-builder` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Docker coverage |
<!-- Technology knowledge base entry for Docker Multi-Stage Builder in Docker DevOps -->