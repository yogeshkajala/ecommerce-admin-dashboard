---
description: "RabbitMQ Security Specialist skill -- Configures RabbitMQ security with TLS, authentication, virtual hosts, and access control for secure messaging infrastructure"
---

# RabbitMQ Security Specialist Skill

**Category:** Tech Skills > Others > RabbitMQ

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for RabbitMQ Security Specialist operations using RabbitMQ technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for RabbitMQ within Others development.

## When to Use

- When securing RabbitMQ with TLS encryption
- When implementing authentication and authorization
- When managing virtual hosts for tenant isolation
- When RabbitMQ-specific technical expertise is required
- When best practices for RabbitMQ technology stack must be applied
- When production-grade RabbitMQ implementation guidance is needed

## Capabilities

- Configure TLS for encrypted connections
- Implement LDAP or OAuth2 authentication
- Design virtual host structure for isolation
- Configure topic-level authorization
- Manage certificates and rotation

## Procedure

1. Configure TLS with proper certificates
2. Set up authentication backend
3. Design virtual host isolation
4. Configure permissions per user/vhost
5. Implement certificate rotation
6. Audit access and connections

## Output Format

Return structured results:

- **TLS Configuration**
- **Auth Setup**
- **Permission Model**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **RabbitMQ Security** | Security configuration best practices |
| **TLS** | Transport layer encryption setup |
| **Authorization** | Permission model and virtual hosts |

## Anti-Hallucination Rules

- Do not use default guest credentials in production
- Verify security features in RabbitMQ version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- TLS is enforced for all connections
- Guest user is disabled in production
- Permissions follow least privilege
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow RabbitMQ community best practices

## Integration Points

- **Companion Agent**: `@rabbitmq-security-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full RabbitMQ coverage |
<!-- Technology knowledge base entry for RabbitMQ Security Specialist in RabbitMQ Others -->
<!-- Technology knowledge base entry for RabbitMQ Security Specialist in RabbitMQ Others -->
<!-- Technology knowledge base entry for RabbitMQ Security Specialist in RabbitMQ Others -->