---
description: "Azure ARM/Bicep Developer skill -- Creates Azure infrastructure as code with ARM templates and Bicep including modules, parameters, and deployment management"
---

# Azure ARM/Bicep Developer Skill

**Category:** Tech Skills > DevOps > Azure

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Azure ARM/Bicep Developer operations using Azure technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Azure within DevOps development.

## When to Use

- When deploying Azure infrastructure with ARM or Bicep
- When creating reusable Bicep modules
- When managing Azure deployments with what-if analysis
- When Azure-specific technical expertise is required
- When best practices for Azure technology stack must be applied
- When production-grade Azure implementation guidance is needed

## Capabilities

- Create Bicep templates with modular design
- Implement parameter files for environments
- Use Bicep modules for code reuse
- Run what-if analysis before deployment
- Configure deployment stacks for lifecycle management

## Procedure

1. Design template structure with modules
2. Implement resources with proper configuration
3. Create parameter files per environment
4. Test with what-if analysis
5. Deploy with proper scope and validation
6. Monitor deployment progress and errors

## Output Format

Return structured results:

- **Bicep Templates**
- **Module Library**
- **Deployment Configuration**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Bicep** | Bicep language and module patterns |
| **ARM Templates** | Template structure and functions |
| **What-If** | Pre-deployment impact analysis |

## Anti-Hallucination Rules

- Do not deploy to production without what-if analysis
- Verify resource provider availability in target region
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Templates validate without errors
- What-if shows expected changes only
- Modules are reusable across projects
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Azure community best practices

## Integration Points

- **Companion Agent**: `@azure-arm-template-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Azure coverage |
<!-- Technology knowledge base entry for Azure ARM/Bicep Developer in Azure DevOps -->
<!-- Technology knowledge base entry for Azure ARM/Bicep Developer in Azure DevOps -->