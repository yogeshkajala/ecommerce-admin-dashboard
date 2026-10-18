---
description: "Nginx Container Specialist skill -- Configures Nginx in Docker and Kubernetes environments with proper image optimization, config injection, and health probes"
---

# Nginx Container Specialist Skill

**Category:** Tech Skills > Others > Nginx

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Nginx Container Specialist operations using Nginx technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Nginx within Others development.

## When to Use

- When deploying Nginx in Docker containers
- When configuring Nginx in Kubernetes with ConfigMaps
- When implementing health probes for containerized Nginx
- When Nginx-specific technical expertise is required
- When best practices for Nginx technology stack must be applied
- When production-grade Nginx implementation guidance is needed

## Capabilities

- Build optimized Nginx Docker images
- Inject configuration with Docker volumes or ConfigMaps
- Configure health probes for orchestrators
- Implement sidecar patterns for Nginx
- Use envsubst for environment-based configuration

## Procedure

1. Design Nginx container architecture
2. Build minimal Docker image
3. Configure volume or ConfigMap injection
4. Add health check endpoints
5. Implement environment-based configuration
6. Test in containerized environment

## Output Format

Return structured results:

- **Docker Configuration**
- **K8s Manifests**
- **Health Probe Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Nginx Docker** | Container deployment patterns |
| **ConfigMap** | Kubernetes configuration injection |
| **Health Probes** | Container health check configuration |

## Anti-Hallucination Rules

- Do not run Nginx as root in containers
- Verify Nginx image version and security
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Container runs as non-root
- Configuration is injected properly
- Health probes detect failures
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Nginx community best practices

## Integration Points

- **Companion Agent**: `@nginx-container-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Nginx coverage |
<!-- Technology knowledge base entry for Nginx Container Specialist in Nginx Others -->
<!-- Technology knowledge base entry for Nginx Container Specialist in Nginx Others -->
<!-- Technology knowledge base entry for Nginx Container Specialist in Nginx Others -->