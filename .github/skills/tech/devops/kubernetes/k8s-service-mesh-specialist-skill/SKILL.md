---
description: "K8s Service Mesh Specialist skill -- Implements service mesh with Istio or Linkerd for traffic management, mTLS, observability, and resilience in Kubernetes"
---

# K8s Service Mesh Specialist Skill

**Category:** Tech Skills > DevOps > Kubernetes

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for K8s Service Mesh Specialist operations using Kubernetes technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Kubernetes within DevOps development.

## When to Use

- When implementing mTLS between microservices
- When configuring traffic management with service mesh
- When adding service mesh observability with distributed tracing
- When Kubernetes-specific technical expertise is required
- When best practices for Kubernetes technology stack must be applied
- When production-grade Kubernetes implementation guidance is needed

## Capabilities

- Deploy Istio or Linkerd service mesh
- Configure mTLS for zero-trust networking
- Implement traffic management with VirtualService and DestinationRule
- Set up distributed tracing with Jaeger
- Configure retries, timeouts, and circuit breaking

## Procedure

1. Choose service mesh based on requirements
2. Deploy mesh control plane
3. Enable sidecar injection for workloads
4. Configure mTLS policies
5. Implement traffic management rules
6. Monitor mesh with built-in observability

## Output Format

Return structured results:

- **Mesh Configuration**
- **Traffic Policies**
- **mTLS Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Istio** | Istio configuration and traffic management |
| **Linkerd** | Lightweight service mesh patterns |
| **mTLS** | Mutual TLS for service-to-service encryption |

## Anti-Hallucination Rules

- Do not enable mesh for all namespaces without performance assessment
- Verify mesh version compatibility with Kubernetes
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- mTLS is enforced for all mesh services
- Traffic policies route correctly
- Mesh overhead is within acceptable limits
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Kubernetes community best practices

## Integration Points

- **Companion Agent**: `@k8s-service-mesh-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Kubernetes coverage |
<!-- Technology knowledge base entry for K8s Service Mesh Specialist in Kubernetes DevOps -->