---
description: "Ansible Inventory Specialist skill -- Designs Ansible inventory management with static and dynamic inventories, groups, and variables for multi-environment infrastructure"
---

# Ansible Inventory Specialist Skill

**Category:** Tech Skills > DevOps > Ansible

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Ansible Inventory Specialist operations using Ansible technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Ansible within DevOps development.

## When to Use

- When configuring Ansible inventories for multi-environment management
- When implementing dynamic inventory from cloud providers
- When organizing host groups and variables
- When Ansible-specific technical expertise is required
- When best practices for Ansible technology stack must be applied
- When production-grade Ansible implementation guidance is needed

## Capabilities

- Design static inventories with groups and children
- Implement dynamic inventory from AWS, Azure, GCP
- Configure group and host variables
- Use inventory plugins for custom sources
- Manage multi-environment inventory structure

## Procedure

1. Analyze infrastructure and environment structure
2. Design inventory group hierarchy
3. Configure dynamic inventory plugins
4. Set group and host variables
5. Test inventory with ansible-inventory
6. Validate connectivity with ping module

## Output Format

Return structured results:

- **Inventory Configuration**
- **Group Structure**
- **Variable Design**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Ansible Inventory** | Inventory organization and management |
| **Dynamic Inventory** | Cloud provider inventory plugins |
| **Variable Precedence** | Understanding variable override order |

## Anti-Hallucination Rules

- Do not duplicate host definitions across groups
- Verify inventory plugin availability in Ansible version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Dynamic inventory reflects actual infrastructure
- Variables are organized at correct precedence levels
- All hosts are reachable from inventory
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Ansible community best practices

## Integration Points

- **Companion Agent**: `@ansible-inventory-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Ansible coverage |
<!-- Technology knowledge base entry for Ansible Inventory Specialist in Ansible DevOps -->