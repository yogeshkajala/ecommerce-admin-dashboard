---
description: "Ansible Playbook Developer skill -- Creates Ansible playbooks for infrastructure automation with proper task design, error handling, and idempotent operations"
---

# Ansible Playbook Developer Skill

**Category:** Tech Skills > DevOps > Ansible

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Ansible Playbook Developer operations using Ansible technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Ansible within DevOps development.

## When to Use

- When automating infrastructure configuration with Ansible
- When creating playbooks for server provisioning
- When implementing configuration management across environments
- When Ansible-specific technical expertise is required
- When best practices for Ansible technology stack must be applied
- When production-grade Ansible implementation guidance is needed

## Capabilities

- Write idempotent playbooks with proper task design
- Implement handlers for service management
- Use variables, facts, and templates for flexibility
- Configure error handling with blocks and rescue
- Optimize execution with strategy and throttling

## Procedure

1. Analyze automation requirements
2. Design playbook structure with roles
3. Implement tasks with idempotency
4. Add error handling and recovery
5. Configure variables for environment flexibility
6. Test with molecule or ansible-lint

## Output Format

Return structured results:

- **Playbook Implementation**
- **Variable Configuration**
- **Test Results**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Ansible Best Practices** | Playbook organization and task design |
| **Idempotency** | Ensuring repeated runs produce same results |
| **ansible-lint** | Playbook quality and style checking |

## Anti-Hallucination Rules

- Do not use shell/command modules where native modules exist
- Verify module availability in target Ansible version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Playbooks are idempotent
- Error handling covers failure modes
- Lint passes without warnings
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Ansible community best practices

## Integration Points

- **Companion Agent**: `@ansible-playbook-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Ansible coverage |
<!-- Technology knowledge base entry for Ansible Playbook Developer in Ansible DevOps -->