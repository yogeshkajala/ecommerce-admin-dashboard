---
description: "Ansible Role Builder skill -- Creates reusable Ansible roles with proper directory structure, defaults, handlers, and molecule testing for infrastructure automation"
---

# Ansible Role Builder Skill

**Category:** Tech Skills > DevOps > Ansible

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Ansible Role Builder operations using Ansible technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Ansible within DevOps development.

## When to Use

- When building reusable Ansible roles for shared automation
- When organizing complex playbooks into role hierarchies
- When publishing roles to Ansible Galaxy
- When Ansible-specific technical expertise is required
- When best practices for Ansible technology stack must be applied
- When production-grade Ansible implementation guidance is needed

## Capabilities

- Create roles with standard directory structure
- Define defaults and variables with proper precedence
- Implement handlers for service lifecycle
- Write molecule tests for role validation
- Publish roles to Galaxy or private repository

## Procedure

1. Design role interface with variables
2. Create role with ansible-galaxy init
3. Implement tasks, handlers, and templates
4. Configure defaults and variable precedence
5. Write molecule tests for all scenarios
6. Document role requirements and usage

## Output Format

Return structured results:

- **Role Implementation**
- **Molecule Tests**
- **Documentation**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Ansible Roles** | Role structure and organization standards |
| **Galaxy** | Role sharing and distribution |
| **Molecule** | Role testing framework |

## Anti-Hallucination Rules

- Do not hardcode values that should be role variables
- Verify role dependency compatibility
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Role works with default variables
- Molecule tests pass on target platforms
- Role documentation is complete
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Ansible community best practices

## Integration Points

- **Companion Agent**: `@ansible-role-builder` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Ansible coverage |
<!-- Technology knowledge base entry for Ansible Role Builder in Ansible DevOps -->
<!-- Technology knowledge base entry for Ansible Role Builder in Ansible DevOps -->