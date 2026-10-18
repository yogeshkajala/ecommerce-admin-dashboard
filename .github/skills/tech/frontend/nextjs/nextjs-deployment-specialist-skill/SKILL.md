---
description: "Next.js Deployment Specialist skill -- Configures Next.js deployment to Vercel, Docker, and self-hosted environments with proper build optimization and caching"
---

# Next.js Deployment Specialist Skill

**Category:** Tech Skills > Frontend > Next.js

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Next.js Deployment Specialist operations using Next.js technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Next.js within Frontend development.

## When to Use

- When deploying Next.js applications to Vercel or Docker
- When configuring standalone output for container deployment
- When optimizing build and deployment pipeline for Next.js
- When Next.js-specific technical expertise is required
- When best practices for Next.js technology stack must be applied
- When production-grade Next.js implementation guidance is needed

## Capabilities

- Configure Vercel deployment with proper settings
- Build Docker images with standalone output mode
- Set up CDN caching for static and dynamic content
- Configure environment variables for different stages
- Implement health checks and graceful shutdown

## Procedure

1. Choose deployment target and configure output mode
2. Set up build optimization with proper caching
3. Configure environment variables and secrets
4. Implement health check endpoints
5. Set up monitoring and error tracking
6. Test deployment with staging environment

## Output Format

Return structured results:

- **Deployment Configuration**
- **Docker Setup**
- **Caching Strategy**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Standalone Output** | Docker-optimized standalone build configuration |
| **Vercel Platform** | Vercel-specific features and configuration |
| **Caching Strategy** | CDN and ISR caching for production deployment |

## Anti-Hallucination Rules

- Do not assume Vercel features are available in self-hosted mode
- Verify standalone output availability in the target Next.js version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Build output is optimized for the target platform
- Environment variables are properly configured
- Health checks and monitoring are in place
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Next.js community best practices

## Integration Points

- **Companion Agent**: `@nextjs-deployment-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Next.js coverage |