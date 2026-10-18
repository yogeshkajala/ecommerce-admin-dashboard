---
description: "Azure AKS Specialist skill -- Deploys and manages Azure Kubernetes Service clusters with proper node pool design, networking, and integration with Azure services"
---

# Azure AKS Specialist Skill

**Category:** Tech Skills > DevOps > Azure

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Azure AKS Specialist operations using Azure technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Azure within DevOps development.

## When to Use

- When deploying AKS clusters for production workloads
- When configuring AKS networking with Azure CNI
- When integrating AKS with Azure Active Directory and Key Vault
- When Azure-specific technical expertise is required
- When best practices for Azure technology stack must be applied
- When production-grade Azure implementation guidance is needed

## Capabilities

- Deploy AKS clusters with proper node pool design
- Configure Azure CNI for networking
- Integrate with Azure AD for RBAC
- Set up Key Vault for secret management
- Configure auto-scaling with cluster autoscaler

## Procedure

1. Design AKS cluster architecture
2. Deploy with proper networking configuration
3. Configure Azure AD integration for RBAC
4. Set up Key Vault CSI driver for secrets
5. Configure monitoring with Azure Monitor
6. Test scaling and failover behavior

## Output Format

Return structured results:

- **AKS Configuration**
- **Network Design**
- **Security Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **AKS Best Practices** | Cluster configuration and security guidelines |
| **Azure CNI** | Networking options for AKS |
| **Managed Identity** | Identity integration for AKS workloads |

## Anti-Hallucination Rules

- Do not use kubenet for production clusters requiring advanced networking
- Verify AKS features in target Azure region
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Cluster meets security baseline requirements
- Networking supports required connectivity
- Auto-scaling handles demand changes
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Azure community best practices

## Integration Points

- **Companion Agent**: `@azure-aks-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Azure coverage |
<!-- Technology knowledge base entry for Azure AKS Specialist in Azure DevOps -->
<!-- Technology knowledge base entry for Azure AKS Specialist in Azure DevOps -->