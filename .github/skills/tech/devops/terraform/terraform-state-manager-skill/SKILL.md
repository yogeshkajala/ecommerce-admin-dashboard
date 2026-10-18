---
description: "Terraform State Manager skill -- Manages Terraform state including remote backends, state locking, state migration, and state file security for team collaboration"
---

# Terraform State Manager Skill

**Category:** Tech Skills > DevOps > Terraform

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Terraform State Manager operations using Terraform technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Terraform within DevOps development.

## When to Use

- When configuring remote state backends for team use
- When migrating state between backends or workspaces
- When resolving state lock issues and state drift
- When Terraform-specific technical expertise is required
- When best practices for Terraform technology stack must be applied
- When production-grade Terraform implementation guidance is needed

## Capabilities

- Configure S3, GCS, or Azure Blob remote backends
- Implement state locking with DynamoDB or equivalent
- Manage workspaces for environment separation
- Migrate state between backends safely
- Handle state import and resource moves

## Procedure

1. Choose remote backend based on cloud provider
2. Configure backend with encryption and locking
3. Set up workspaces for environment management
4. Implement state backup procedures
5. Handle state operations: import, mv, rm
6. Monitor for state drift with plan comparisons

## Output Format

Return structured results:

- **Backend Configuration**
- **Locking Strategy**
- **Migration Plan**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Remote Backends** | Backend configuration and security |
| **State Locking** | Concurrent access prevention |
| **State Security** | Encryption and access control for state files |

## Anti-Hallucination Rules

- Do not manually edit state files without understanding consequences
- Verify backend features in target Terraform version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- State is encrypted at rest
- Locking prevents concurrent modifications
- State backup procedures are tested
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Terraform community best practices

## Integration Points

- **Companion Agent**: `@terraform-state-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Terraform coverage |
<!-- Technology knowledge base entry for Terraform State Manager in Terraform DevOps -->