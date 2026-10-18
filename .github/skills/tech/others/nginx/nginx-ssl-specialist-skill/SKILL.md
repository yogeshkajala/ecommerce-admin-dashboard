---
description: "Nginx SSL/TLS Specialist skill -- Configures Nginx SSL/TLS with proper certificate management, cipher suites, and HSTS for secure HTTPS communication"
---

# Nginx SSL/TLS Specialist Skill

**Category:** Tech Skills > Others > Nginx

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Nginx SSL/TLS Specialist operations using Nginx technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Nginx within Others development.

## When to Use

- When configuring SSL/TLS for Nginx with proper security
- When implementing HSTS and OCSP stapling
- When managing SSL certificates with Let's Encrypt
- When Nginx-specific technical expertise is required
- When best practices for Nginx technology stack must be applied
- When production-grade Nginx implementation guidance is needed

## Capabilities

- Configure SSL/TLS with modern cipher suites
- Implement HSTS for strict transport security
- Set up OCSP stapling for certificate validation
- Automate certificate renewal with certbot
- Configure HTTP/2 with SSL

## Procedure

1. Choose SSL/TLS configuration profile
2. Configure certificates and private keys
3. Set cipher suites and protocols
4. Enable HSTS and OCSP stapling
5. Automate renewal with certbot
6. Test with SSL Labs for grade

## Output Format

Return structured results:

- **SSL Configuration**
- **Certificate Setup**
- **Security Headers**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **SSL Configuration** | TLS configuration best practices |
| **Mozilla SSL Config** | Modern, intermediate, old compatibility |
| **HSTS** | HTTP Strict Transport Security |

## Anti-Hallucination Rules

- Do not use SSL protocols older than TLS 1.2
- Verify certificate chain completeness
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- SSL Labs score is A or higher
- HSTS is configured with proper max-age
- Certificate renewal is automated
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Nginx community best practices

## Integration Points

- **Companion Agent**: `@nginx-ssl-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Nginx coverage |
<!-- Technology knowledge base entry for Nginx SSL/TLS Specialist in Nginx Others -->
<!-- Technology knowledge base entry for Nginx SSL/TLS Specialist in Nginx Others -->
<!-- Technology knowledge base entry for Nginx SSL/TLS Specialist in Nginx Others -->