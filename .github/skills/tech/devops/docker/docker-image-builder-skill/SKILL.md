---
description: "Docker Image Builder skill -- Creates optimized Docker images with multi-stage builds, layer caching, and security scanning for production container deployments"
---

# Docker Image Builder Skill

**Category:** Tech Skills > DevOps > Docker

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Docker Image Builder operations using Docker technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Docker within DevOps development.

## When to Use

- When building production Docker images with minimal size
- When implementing multi-stage builds for build optimization
- When scanning images for vulnerabilities before deployment
- When Docker-specific technical expertise is required
- When best practices for Docker technology stack must be applied
- When production-grade Docker implementation guidance is needed

## Capabilities

- Build multi-stage Dockerfiles for optimal image size
- Configure layer caching for faster builds
- Implement build arguments and secrets handling
- Scan images with Trivy or Docker Scout
- Optimize base image selection for security and size

## Procedure

1. Design Dockerfile with multi-stage build
2. Optimize layer ordering for cache efficiency
3. Configure build arguments and secrets
4. Scan final image for vulnerabilities
5. Test image with container structure tests
6. Push to registry with proper tagging

## Output Format

Return structured results:

- **Dockerfile**
- **Image Analysis**
- **Security Scan**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Dockerfile Best Practices** | Official Dockerfile optimization guidelines |
| **Image Security** | Vulnerability scanning and minimal base images |
| **Build Cache** | Layer caching strategies for CI/CD |

## Anti-Hallucination Rules

- Do not run containers as root without justification
- Verify base image availability and support status
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Image size is minimized
- No critical vulnerabilities in scan
- Build cache is utilized effectively
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Docker community best practices

## Integration Points

- **Companion Agent**: `@docker-image-builder` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Docker coverage |
<!-- Technology knowledge base entry for Docker Image Builder in Docker DevOps -->
<!-- Technology knowledge base entry for Docker Image Builder in Docker DevOps -->