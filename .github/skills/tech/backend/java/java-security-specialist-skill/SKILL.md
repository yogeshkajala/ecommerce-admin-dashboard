---
description: "Java Security Specialist skill -- Implements security features in Java applications using Spring Security, JWT authentication, OAuth2, and encryption best practices"
---

# Java Security Specialist Skill

**Category:** Tech Skills > Backend > Java

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Java Security Specialist operations using Java technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Java within Backend development.

## When to Use

- When implementing authentication and authorization with Spring Security
- When configuring OAuth2 and JWT token-based security
- When encrypting sensitive data with Java Cryptography Architecture
- When Java-specific technical expertise is required
- When best practices for Java technology stack must be applied
- When production-grade Java implementation guidance is needed

## Capabilities

- Configure Spring Security with custom authentication providers
- Implement JWT token generation and validation
- Set up OAuth2 resource server and client
- Apply method-level security with annotations
- Implement encryption with JCA and Bouncy Castle

## Procedure

1. Analyze security requirements and threat model
2. Configure authentication mechanism
3. Implement authorization rules and access control
4. Set up token-based authentication if needed
5. Add encryption for sensitive data
6. Test security configuration with integration tests

## Output Format

Return structured results:

- **Security Configuration**
- **Authentication Flow**
- **Authorization Rules**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Spring Security** | Spring Security configuration and patterns |
| **OAuth2/OIDC** | OAuth2 and OpenID Connect protocols |
| **OWASP Java** | OWASP Java security guidelines |

## Anti-Hallucination Rules

- Do not hardcode secrets or credentials in code
- Verify Spring Security version compatibility with Spring Boot
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Authentication rejects invalid credentials
- Authorization enforces least privilege
- No sensitive data is exposed in logs or responses
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Java community best practices

## Integration Points

- **Companion Agent**: `@java-security-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Java coverage |
<!-- Technology knowledge base entry for Java Security Specialist in Java Backend -->