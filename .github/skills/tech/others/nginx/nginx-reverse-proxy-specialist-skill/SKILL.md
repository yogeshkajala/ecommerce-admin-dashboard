---
description: "Nginx Reverse Proxy Specialist skill -- Configures Nginx as a reverse proxy with upstream balancing, header management, and WebSocket support for application delivery"
---

# Nginx Reverse Proxy Specialist Skill

**Category:** Tech Skills > Others > Nginx

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Nginx Reverse Proxy Specialist operations using Nginx technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Nginx within Others development.

## When to Use

- When configuring Nginx as a reverse proxy for applications
- When implementing load balancing with upstream directives
- When handling WebSocket proxying with Nginx
- When Nginx-specific technical expertise is required
- When best practices for Nginx technology stack must be applied
- When production-grade Nginx implementation guidance is needed

## Capabilities

- Configure reverse proxy with proxy_pass
- Implement upstream load balancing
- Handle WebSocket upgrade headers
- Configure proxy headers for client info
- Implement health checks for upstream servers

## Procedure

1. Design reverse proxy architecture
2. Configure upstream server groups
3. Set up proxy_pass with proper headers
4. Add WebSocket support if needed
5. Configure health checks
6. Test failover and load distribution

## Output Format

Return structured results:

- **Nginx Configuration**
- **Upstream Setup**
- **Health Check Config**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Reverse Proxy** | Nginx proxy configuration patterns |
| **Load Balancing** | Upstream balancing algorithms |
| **WebSocket** | WebSocket proxy configuration |

## Anti-Hallucination Rules

- Do not proxy to upstream without proper timeout configuration
- Verify Nginx features in target version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Traffic is distributed across upstreams
- WebSocket connections are proxied correctly
- Health checks detect failed upstreams
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Nginx community best practices

## Integration Points

- **Companion Agent**: `@nginx-reverse-proxy-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Nginx coverage |
<!-- Technology knowledge base entry for Nginx Reverse Proxy Specialist in Nginx Others -->
<!-- Technology knowledge base entry for Nginx Reverse Proxy Specialist in Nginx Others -->