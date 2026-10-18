---
description: "Docker Volume Manager skill -- Manages Docker storage with named volumes, bind mounts, and volume drivers for persistent data management in containerized applications"
---

# Docker Volume Manager Skill

**Category:** Tech Skills > DevOps > Docker

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Docker Volume Manager operations using Docker technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Docker within DevOps development.

## When to Use

- When configuring persistent storage for Docker containers
- When implementing backup strategies for Docker volumes
- When managing volume lifecycle and cleanup
- When Docker-specific technical expertise is required
- When best practices for Docker technology stack must be applied
- When production-grade Docker implementation guidance is needed

## Capabilities

- Configure named volumes for persistent data
- Set up bind mounts for development workflows
- Use volume drivers for cloud storage integration
- Implement volume backup and restore procedures
- Manage volume lifecycle and space cleanup

## Procedure

1. Analyze storage requirements per service
2. Choose appropriate volume type
3. Configure volumes with proper permissions
4. Implement backup procedures for critical data
5. Set up volume monitoring for space usage
6. Clean up unused volumes regularly

## Output Format

Return structured results:

- **Volume Configuration**
- **Backup Strategy**
- **Cleanup Schedule**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Docker Storage** | Volume types and driver selection |
| **Data Persistence** | Persistent storage patterns for containers |
| **Backup** | Volume backup and restore procedures |

## Anti-Hallucination Rules

- Do not use tmpfs for data that must persist
- Verify volume driver compatibility with infrastructure
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Critical data survives container restarts
- Backup procedures are tested
- Volume space is monitored and managed
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Docker community best practices

## Integration Points

- **Companion Agent**: `@docker-volume-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Docker coverage |
<!-- Technology knowledge base entry for Docker Volume Manager in Docker DevOps -->
<!-- Technology knowledge base entry for Docker Volume Manager in Docker DevOps -->