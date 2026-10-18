---
description: "Jenkins Security Configurator skill -- Configures Jenkins security including authentication, authorization, credentials management, and agent security for production deployments"
---

# Jenkins Security Configurator Skill

**Category:** Tech Skills > DevOps > Jenkins

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Jenkins Security Configurator operations using Jenkins technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Jenkins within DevOps development.

## When to Use

- When configuring Jenkins authentication with LDAP or OIDC
- When implementing matrix-based authorization
- When securing Jenkins agents and credentials
- When Jenkins-specific technical expertise is required
- When best practices for Jenkins technology stack must be applied
- When production-grade Jenkins implementation guidance is needed

## Capabilities

- Configure LDAP and OIDC authentication
- Implement matrix-based security authorization
- Manage credentials with proper scoping
- Secure agent communication with JNLP or SSH
- Configure CSRF protection and security headers

## Procedure

1. Configure authentication provider
2. Set up authorization strategy
3. Organize credentials by scope and domain
4. Secure agent connections
5. Enable CSRF and security headers
6. Audit security configuration regularly

## Output Format

Return structured results:

- **Security Configuration**
- **Credential Setup**
- **Agent Security**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Jenkins Security** | Security configuration best practices |
| **Credentials** | Credential management and scoping |
| **Agent Security** | Secure agent communication patterns |

## Anti-Hallucination Rules

- Do not disable CSRF protection in production
- Verify security plugin compatibility with Jenkins version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Authentication prevents unauthorized access
- Authorization enforces least privilege
- Credentials are scoped appropriately
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Jenkins community best practices

## Integration Points

- **Companion Agent**: `@jenkins-security-configurator` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Jenkins coverage |
<!-- Technology knowledge base entry for Jenkins Security Configurator in Jenkins DevOps -->
<!-- Technology knowledge base entry for Jenkins Security Configurator in Jenkins DevOps -->