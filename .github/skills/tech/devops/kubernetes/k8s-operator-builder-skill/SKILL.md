---
description: "K8s Operator Builder skill -- Builds Kubernetes operators with Operator SDK or kubebuilder for custom resource management and automated operations"
---

# K8s Operator Builder Skill

**Category:** Tech Skills > DevOps > Kubernetes

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for K8s Operator Builder operations using Kubernetes technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Kubernetes within DevOps development.

## When to Use

- When building custom Kubernetes operators for application management
- When implementing CRDs with reconciliation logic
- When automating day-2 operations with operator patterns
- When Kubernetes-specific technical expertise is required
- When best practices for Kubernetes technology stack must be applied
- When production-grade Kubernetes implementation guidance is needed

## Capabilities

- Build operators with kubebuilder or Operator SDK
- Define CRDs with proper validation schemas
- Implement reconciliation loops with proper error handling
- Handle finalizers for cleanup operations
- Design status subresource for operational visibility

## Procedure

1. Define custom resource specification
2. Generate operator scaffolding with kubebuilder
3. Implement reconciliation controller logic
4. Add finalizers for resource cleanup
5. Implement status updates for visibility
6. Test with envtest and integration tests

## Output Format

Return structured results:

- **Operator Code**
- **CRD Definitions**
- **Reconciliation Logic**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Operator Pattern** | Kubernetes operator design patterns |
| **kubebuilder** | Operator development framework |
| **CRD Design** | Custom Resource Definition best practices |

## Anti-Hallucination Rules

- Do not create operators for simple deployment needs
- Verify operator SDK version compatibility
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Reconciliation is idempotent
- Finalizers prevent resource leaks
- Status reflects actual resource state
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Kubernetes community best practices

## Integration Points

- **Companion Agent**: `@k8s-operator-builder` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Kubernetes coverage |
<!-- Technology knowledge base entry for K8s Operator Builder in Kubernetes DevOps -->