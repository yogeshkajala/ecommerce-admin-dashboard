---
description: "K8s Deployment Specialist skill -- Implements Kubernetes deployments with rolling updates, resource management, and pod lifecycle configuration for production workloads"
---

# K8s Deployment Specialist Skill

**Category:** Tech Skills > DevOps > Kubernetes

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for K8s Deployment Specialist operations using Kubernetes technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Kubernetes within DevOps development.

## When to Use

- When deploying applications to Kubernetes with proper resource limits
- When configuring rolling update strategies and readiness probes
- When managing pod disruption budgets for availability
- When Kubernetes-specific technical expertise is required
- When best practices for Kubernetes technology stack must be applied
- When production-grade Kubernetes implementation guidance is needed

## Capabilities

- Configure Deployments with proper resource requests and limits
- Implement rolling update and recreate strategies
- Set up readiness, liveness, and startup probes
- Configure pod disruption budgets for maintenance
- Implement init containers for initialization tasks

## Procedure

1. Design deployment manifests with resource requirements
2. Configure update strategy and maxSurge/maxUnavailable
3. Add health probes for proper lifecycle management
4. Set resource requests and limits based on profiling
5. Configure PDB for high availability
6. Test deployment rollout and rollback

## Output Format

Return structured results:

- **Deployment Manifests**
- **Resource Configuration**
- **Health Probe Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **K8s Deployments** | Deployment configuration best practices |
| **Resource Management** | CPU and memory requests/limits guidelines |
| **Health Probes** | Probe configuration for pod lifecycle |

## Anti-Hallucination Rules

- Do not omit resource limits in production deployments
- Verify API version compatibility with cluster version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Resource limits prevent node exhaustion
- Health probes detect unhealthy pods
- Rolling updates maintain availability
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Kubernetes community best practices

## Integration Points

- **Companion Agent**: `@k8s-deployment-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Kubernetes coverage |