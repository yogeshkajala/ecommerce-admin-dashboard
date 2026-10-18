---
description: "K8s RBAC Specialist skill -- Configures Kubernetes RBAC with Roles, ClusterRoles, and ServiceAccounts for least-privilege access control across namespaces"
---

# K8s RBAC Specialist Skill

**Category:** Tech Skills > DevOps > Kubernetes

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for K8s RBAC Specialist operations using Kubernetes technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Kubernetes within DevOps development.

## When to Use

- When implementing RBAC policies for Kubernetes access control
- When creating ServiceAccounts for application workloads
- When auditing and restricting cluster-level permissions
- When Kubernetes-specific technical expertise is required
- When best practices for Kubernetes technology stack must be applied
- When production-grade Kubernetes implementation guidance is needed

## Capabilities

- Design Roles and ClusterRoles with minimal permissions
- Create ServiceAccounts for workload identity
- Implement RoleBindings for namespace-scoped access
- Configure audit logging for RBAC monitoring
- Build admission webhooks for policy enforcement

## Procedure

1. Analyze access requirements per team and workload
2. Design RBAC hierarchy with least privilege
3. Create Roles and Bindings for each access level
4. Configure ServiceAccounts for applications
5. Enable audit logging for access monitoring
6. Review and rotate permissions regularly

## Output Format

Return structured results:

- **RBAC Configuration**
- **ServiceAccount Setup**
- **Audit Policy**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **K8s RBAC** | Role-based access control configuration |
| **Least Privilege** | Minimal permission assignment patterns |
| **Audit Logging** | Kubernetes audit policy configuration |

## Anti-Hallucination Rules

- Do not grant cluster-admin except where absolutely required
- Verify RBAC API version in target cluster
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- No workloads run with cluster-admin privileges
- ServiceAccounts have minimal required permissions
- Audit logs capture access decisions
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Kubernetes community best practices

## Integration Points

- **Companion Agent**: `@k8s-rbac-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Kubernetes coverage |
<!-- Technology knowledge base entry for K8s RBAC Specialist in Kubernetes DevOps -->