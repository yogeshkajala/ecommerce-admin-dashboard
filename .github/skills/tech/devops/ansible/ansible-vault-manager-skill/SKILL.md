---
description: "Ansible Vault Manager skill -- Manages secrets and sensitive data with Ansible Vault including encryption, key rotation, and integration with external secret stores"
---

# Ansible Vault Manager Skill

**Category:** Tech Skills > DevOps > Ansible

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Ansible Vault Manager operations using Ansible technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Ansible within DevOps development.

## When to Use

- When encrypting sensitive data with Ansible Vault
- When integrating with external secret management systems
- When implementing key rotation for vault passwords
- When Ansible-specific technical expertise is required
- When best practices for Ansible technology stack must be applied
- When production-grade Ansible implementation guidance is needed

## Capabilities

- Encrypt files and strings with ansible-vault
- Integrate with HashiCorp Vault for dynamic secrets
- Configure multiple vault IDs for different environments
- Implement key rotation procedures
- Use lookup plugins for external secret retrieval

## Procedure

1. Identify sensitive data requiring encryption
2. Encrypt with ansible-vault
3. Configure vault password management
4. Integrate external secret stores if needed
5. Implement key rotation schedule
6. Audit secret usage and access

## Output Format

Return structured results:

- **Vault Configuration**
- **Secret Integration**
- **Rotation Schedule**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Ansible Vault** | Built-in encryption for sensitive data |
| **Secret Management** | External secret store integration patterns |
| **Key Rotation** | Vault password rotation procedures |

## Anti-Hallucination Rules

- Do not commit vault passwords to version control
- Verify vault feature compatibility with Ansible version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- All sensitive data is encrypted
- Vault passwords are securely managed
- Key rotation is scheduled and tested
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Ansible community best practices

## Integration Points

- **Companion Agent**: `@ansible-vault-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Ansible coverage |
<!-- Technology knowledge base entry for Ansible Vault Manager in Ansible DevOps -->
<!-- Technology knowledge base entry for Ansible Vault Manager in Ansible DevOps -->