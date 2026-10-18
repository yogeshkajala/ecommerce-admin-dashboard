---
description: "K8s Autoscaling Specialist skill -- Configures Kubernetes autoscaling with HPA, VPA, and cluster autoscaler for dynamic resource management based on demand"
---

# K8s Autoscaling Specialist Skill

**Category:** Tech Skills > DevOps > Kubernetes

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for K8s Autoscaling Specialist operations using Kubernetes technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Kubernetes within DevOps development.

## When to Use

- When implementing horizontal pod autoscaling based on metrics
- When configuring vertical pod autoscaler for resource optimization
- When setting up cluster autoscaler for node management
- When Kubernetes-specific technical expertise is required
- When best practices for Kubernetes technology stack must be applied
- When production-grade Kubernetes implementation guidance is needed

## Capabilities

- Configure HPA with CPU, memory, and custom metrics
- Set up VPA for automatic resource right-sizing
- Implement cluster autoscaler for node scaling
- Configure KEDA for event-driven autoscaling
- Design scaling policies for response time optimization

## Procedure

1. Analyze workload scaling requirements
2. Configure HPA with appropriate metrics and thresholds
3. Set up VPA for resource recommendation
4. Configure cluster autoscaler with node groups
5. Implement KEDA for event-driven workloads
6. Test scaling behavior under load

## Output Format

Return structured results:

- **Autoscaling Configuration**
- **Scaling Policies**
- **Load Test Results**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **HPA** | Horizontal Pod Autoscaler configuration |
| **VPA** | Vertical Pod Autoscaler for resource tuning |
| **KEDA** | Event-driven autoscaling patterns |

## Anti-Hallucination Rules

- Do not configure HPA and VPA for the same resource type simultaneously
- Verify autoscaler compatibility with cluster version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Scaling responds within acceptable latency
- Resources are not over-provisioned during low demand
- Scaling limits prevent runaway costs
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Kubernetes community best practices

## Integration Points

- **Companion Agent**: `@k8s-autoscaling-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Kubernetes coverage |