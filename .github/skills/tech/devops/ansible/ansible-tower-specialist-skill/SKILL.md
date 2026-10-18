---
description: "Ansible Tower/AWX Specialist skill -- Configures Ansible Tower or AWX for enterprise automation with job templates, workflows, and RBAC for team collaboration"
---

# Ansible Tower/AWX Specialist Skill

**Category:** Tech Skills > DevOps > Ansible

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Ansible Tower/AWX Specialist operations using Ansible technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Ansible within DevOps development.

## When to Use

- When setting up Ansible Tower or AWX for enterprise use
- When creating job templates and workflow templates
- When implementing RBAC for multi-team automation
- When Ansible-specific technical expertise is required
- When best practices for Ansible technology stack must be applied
- When production-grade Ansible implementation guidance is needed

## Capabilities

- Configure job templates with proper credentials
- Build workflow templates for complex automation
- Implement RBAC with organizations and teams
- Set up surveys for parameterized execution
- Configure notifications and callback URLs

## Procedure

1. Deploy Tower or AWX platform
2. Configure organizations and teams
3. Create credentials and inventories
4. Build job and workflow templates
5. Set up RBAC for access control
6. Configure notifications and integrations

## Output Format

Return structured results:

- **Tower Configuration**
- **Workflow Design**
- **RBAC Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Ansible Tower** | Enterprise automation platform configuration |
| **Workflows** | Multi-step automation orchestration |
| **RBAC** | Role-based access control for automation |

## Anti-Hallucination Rules

- Do not grant admin access to all users
- Verify Tower version compatibility with Ansible version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- RBAC restricts access appropriately
- Workflows handle failures gracefully
- Credentials are securely stored
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Ansible community best practices

## Integration Points

- **Companion Agent**: `@ansible-tower-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Ansible coverage |
<!-- Technology knowledge base entry for Ansible Tower/AWX Specialist in Ansible DevOps -->
<!-- Technology knowledge base entry for Ansible Tower/AWX Specialist in Ansible DevOps -->