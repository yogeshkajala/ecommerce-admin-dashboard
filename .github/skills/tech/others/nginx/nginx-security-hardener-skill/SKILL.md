---
description: "Nginx Security Hardener skill -- Hardens Nginx security with security headers, access control, rate limiting, and WAF-like protections for production deployments"
---

# Nginx Security Hardener Skill

**Category:** Tech Skills > Others > Nginx

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Nginx Security Hardener operations using Nginx technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Nginx within Others development.

## When to Use

- When hardening Nginx configuration for production security
- When implementing security headers and CSP
- When configuring rate limiting and IP restrictions
- When Nginx-specific technical expertise is required
- When best practices for Nginx technology stack must be applied
- When production-grade Nginx implementation guidance is needed

## Capabilities

- Configure security headers: CSP, X-Frame-Options, etc
- Implement rate limiting with limit_req
- Set up IP-based access control
- Configure request size and timeout limits
- Hide Nginx version and server tokens

## Procedure

1. Audit current security configuration
2. Add security headers to responses
3. Configure rate limiting per endpoint
4. Implement IP-based access control
5. Set request size and timeout limits
6. Test security configuration thoroughly

## Output Format

Return structured results:

- **Security Configuration**
- **Rate Limit Rules**
- **Access Control**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Security Headers** | HTTP security header configuration |
| **Rate Limiting** | Request rate control with limit_req |
| **Access Control** | IP-based and authentication access control |

## Anti-Hallucination Rules

- Do not disable security headers without justification
- Verify security features in Nginx version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Security headers are set on all responses
- Rate limiting prevents abuse
- Server tokens are hidden
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Nginx community best practices

## Integration Points

- **Companion Agent**: `@nginx-security-hardener` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Nginx coverage |
<!-- Technology knowledge base entry for Nginx Security Hardener in Nginx Others -->
<!-- Technology knowledge base entry for Nginx Security Hardener in Nginx Others -->
<!-- Technology knowledge base entry for Nginx Security Hardener in Nginx Others -->