---
description: "Azure Networking Specialist skill -- Designs Azure networking with VNets, NSGs, Application Gateway, and Front Door for secure and performant cloud infrastructure"
---

# Azure Networking Specialist Skill

**Category:** Tech Skills > DevOps > Azure

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Azure Networking Specialist operations using Azure technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Azure within DevOps development.

## When to Use

- When designing Azure VNet architecture for production
- When configuring Application Gateway for load balancing
- When implementing Azure Front Door for global distribution
- When Azure-specific technical expertise is required
- When best practices for Azure technology stack must be applied
- When production-grade Azure implementation guidance is needed

## Capabilities

- Design VNet with proper subnet planning
- Configure NSGs with least privilege rules
- Set up Application Gateway with WAF
- Implement Azure Front Door for global routing
- Configure Private Link for service access

## Procedure

1. Design VNet architecture and CIDR planning
2. Configure subnets and NSG rules
3. Set up load balancing with Application Gateway
4. Implement Front Door for global distribution
5. Configure Private Link endpoints
6. Test connectivity and security

## Output Format

Return structured results:

- **Network Architecture**
- **NSG Rules**
- **Load Balancer Config**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Azure Networking** | VNet design and security best practices |
| **Application Gateway** | L7 load balancing with WAF |
| **Private Link** | Private connectivity to Azure services |

## Anti-Hallucination Rules

- Do not allow unrestricted NSG rules without justification
- Verify networking features in target Azure region
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- NSGs follow least privilege
- Private Link reduces public exposure
- Load balancing distributes traffic evenly
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Azure community best practices

## Integration Points

- **Companion Agent**: `@azure-networking-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Azure coverage |
<!-- Technology knowledge base entry for Azure Networking Specialist in Azure DevOps -->
<!-- Technology knowledge base entry for Azure Networking Specialist in Azure DevOps -->