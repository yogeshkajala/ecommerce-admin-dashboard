---
description: "K8s Networking Specialist skill -- Configures Kubernetes networking with Services, Ingress, Network Policies, and service mesh for secure communication"
---

# K8s Networking Specialist Skill

**Category:** Tech Skills > DevOps > Kubernetes

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for K8s Networking Specialist operations using Kubernetes technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Kubernetes within DevOps development.

## When to Use

- When configuring Kubernetes Services and Ingress resources
- When implementing Network Policies for pod isolation
- When setting up service mesh for observability and security
- When Kubernetes-specific technical expertise is required
- When best practices for Kubernetes technology stack must be applied
- When production-grade Kubernetes implementation guidance is needed

## Capabilities

- Configure ClusterIP, NodePort, and LoadBalancer Services
- Implement Ingress with TLS termination
- Create Network Policies for pod-level isolation
- Configure service mesh with Istio or Linkerd
- Set up DNS policies and external DNS

## Procedure

1. Design service networking architecture
2. Configure Services with appropriate types
3. Implement Ingress with routing rules
4. Create Network Policies for isolation
5. Configure service mesh if needed
6. Test connectivity and isolation

## Output Format

Return structured results:

- **Network Configuration**
- **Ingress Setup**
- **Network Policies**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **K8s Networking** | Service and Ingress configuration patterns |
| **Network Policies** | Pod-level network isolation |
| **Service Mesh** | Istio/Linkerd traffic management and security |

## Anti-Hallucination Rules

- Do not assume Network Policies are enforced without a CNI that supports them
- Verify Ingress controller compatibility
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Services are reachable from intended clients only
- Network Policies enforce least-privilege access
- TLS is configured for external traffic
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Kubernetes community best practices

## Integration Points

- **Companion Agent**: `@k8s-networking-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Kubernetes coverage |
<!-- Technology knowledge base entry for K8s Networking Specialist in Kubernetes DevOps -->