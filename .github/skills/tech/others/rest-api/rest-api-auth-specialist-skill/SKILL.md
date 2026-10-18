---
description: "REST API Auth Specialist skill -- Implements REST API authentication and authorization with OAuth2, JWT, and API keys for secure API access control"
---

# REST API Auth Specialist Skill

**Category:** Tech Skills > Others > REST API

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for REST API Auth Specialist operations using REST API technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for REST API within Others development.

## When to Use

- When implementing OAuth2 for API authentication
- When configuring JWT-based API authorization
- When managing API keys for service-to-service access
- When REST API-specific technical expertise is required
- When best practices for REST API technology stack must be applied
- When production-grade REST API implementation guidance is needed

## Capabilities

- Implement OAuth2 authorization flows
- Configure JWT validation and claims
- Manage API key lifecycle and rotation
- Implement scope-based authorization
- Set up rate limiting per authentication method

## Procedure

1. Choose authentication method for use case
2. Implement authentication middleware
3. Configure token validation
4. Implement authorization checks
5. Set up rate limiting
6. Test security controls

## Output Format

Return structured results:

- **Auth Configuration**
- **Token Validation**
- **Rate Limiting**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **OAuth2** | OAuth2 authorization framework |
| **JWT** | JSON Web Token specification |
| **API Security** | OWASP API Security Top 10 |

## Anti-Hallucination Rules

- Do not store secrets in JWT payloads
- Verify OAuth2 grant type is appropriate for use case
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Authentication prevents unauthorized access
- Tokens are properly validated
- Rate limiting prevents abuse
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow REST API community best practices

## Integration Points

- **Companion Agent**: `@rest-api-auth-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full REST API coverage |
<!-- Technology knowledge base entry for REST API Auth Specialist in REST API Others -->
<!-- Technology knowledge base entry for REST API Auth Specialist in REST API Others -->
<!-- Technology knowledge base entry for REST API Auth Specialist in REST API Others -->
<!-- Technology knowledge base entry for REST API Auth Specialist in REST API Others -->