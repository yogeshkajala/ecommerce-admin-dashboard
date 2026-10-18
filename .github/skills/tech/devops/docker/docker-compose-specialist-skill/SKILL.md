---
description: "Docker Compose Specialist skill -- Orchestrates multi-container applications with Docker Compose including service dependencies, networking, and volume management"
---

# Docker Compose Specialist Skill

**Category:** Tech Skills > DevOps > Docker

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Docker Compose Specialist operations using Docker technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Docker within DevOps development.

## When to Use

- When defining multi-container application stacks
- When configuring service dependencies and health checks
- When managing development environments with Compose
- When Docker-specific technical expertise is required
- When best practices for Docker technology stack must be applied
- When production-grade Docker implementation guidance is needed

## Capabilities

- Define multi-service applications with compose.yaml
- Configure service dependencies with depends_on and healthcheck
- Set up custom networks for service isolation
- Manage volumes for persistent data
- Implement profiles for environment-specific services

## Procedure

1. Analyze application service dependencies
2. Design compose file with proper service definitions
3. Configure networking and service discovery
4. Add health checks for dependency management
5. Set up volumes for data persistence
6. Test with docker compose up and validate

## Output Format

Return structured results:

- **Compose Configuration**
- **Network Design**
- **Volume Strategy**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Compose Specification** | Official Compose file format and features |
| **Service Discovery** | DNS-based service discovery in Compose |
| **Health Checks** | Container health check configuration |

## Anti-Hallucination Rules

- Do not hardcode credentials in compose files
- Verify Compose file version features
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Services start in correct dependency order
- Health checks detect unhealthy containers
- Volumes persist data across restarts
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Docker community best practices

## Integration Points

- **Companion Agent**: `@docker-compose-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Docker coverage |
<!-- Technology knowledge base entry for Docker Compose Specialist in Docker DevOps -->