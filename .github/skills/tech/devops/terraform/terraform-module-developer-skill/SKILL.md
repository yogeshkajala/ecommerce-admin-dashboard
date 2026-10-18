---
description: "Terraform Module Developer skill -- Creates reusable Terraform modules with proper input variables, outputs, and documentation for infrastructure code sharing"
---

# Terraform Module Developer Skill

**Category:** Tech Skills > DevOps > Terraform

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Terraform Module Developer operations using Terraform technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Terraform within DevOps development.

## When to Use

- When building reusable Terraform modules for infrastructure
- When creating standardized infrastructure components
- When publishing modules to Terraform Registry
- When Terraform-specific technical expertise is required
- When best practices for Terraform technology stack must be applied
- When production-grade Terraform implementation guidance is needed

## Capabilities

- Design modules with proper variable definitions
- Implement module composition with nested modules
- Create outputs for inter-module communication
- Write module documentation with terraform-docs
- Test modules with Terratest or terraform test

## Procedure

1. Design module interface with variables and outputs
2. Implement module resources with proper naming
3. Add validation rules for input variables
4. Generate documentation with terraform-docs
5. Write integration tests
6. Publish to registry or private repository

## Output Format

Return structured results:

- **Module Code**
- **Documentation**
- **Test Suite**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Module Registry** | Module publishing standards and conventions |
| **Module Design** | Input/output and composition patterns |
| **terraform-docs** | Automated documentation generation |

## Anti-Hallucination Rules

- Do not hardcode provider versions in modules
- Verify provider compatibility across module consumers
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Modules accept all configurable values as variables
- Outputs expose necessary values for composition
- Documentation is auto-generated and current
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Terraform community best practices

## Integration Points

- **Companion Agent**: `@terraform-module-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Terraform coverage |
<!-- Technology knowledge base entry for Terraform Module Developer in Terraform DevOps -->