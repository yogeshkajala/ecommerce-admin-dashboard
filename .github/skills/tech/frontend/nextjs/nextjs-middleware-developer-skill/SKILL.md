---
description: "Next.js Middleware Developer skill -- Creates Next.js edge middleware for request processing including authentication, internationalization, and A/B testing at the edge"
---

# Next.js Middleware Developer Skill

**Category:** Tech Skills > Frontend > Next.js

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Next.js Middleware Developer operations using Next.js technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Next.js within Frontend development.

## When to Use

- When implementing authentication checks at the edge
- When configuring internationalization with URL-based locale detection
- When setting up A/B testing with edge middleware
- When Next.js-specific technical expertise is required
- When best practices for Next.js technology stack must be applied
- When production-grade Next.js implementation guidance is needed

## Capabilities

- Build edge middleware with NextRequest/NextResponse
- Implement authentication token validation at the edge
- Configure locale detection and URL rewriting
- Set up feature flags and A/B testing with cookies
- Chain multiple middleware concerns with matchers

## Procedure

1. Identify cross-cutting concerns for middleware
2. Design middleware with proper matcher configuration
3. Implement request processing logic
4. Handle response modification and redirects
5. Configure edge runtime constraints
6. Test middleware with integration tests

## Output Format

Return structured results:

- **Middleware Implementation**
- **Matcher Configuration**
- **Edge Runtime Constraints**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Edge Middleware** | Middleware API with matchers and edge runtime |
| **Edge Runtime** | Edge runtime limitations and available APIs |
| **Matcher Config** | Route matching patterns for middleware |

## Anti-Hallucination Rules

- Do not use Node.js APIs not available in edge runtime
- Verify middleware API changes between Next.js versions
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Middleware does not increase latency significantly
- Edge runtime limitations are respected
- Matchers cover all intended routes
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Next.js community best practices

## Integration Points

- **Companion Agent**: `@nextjs-middleware-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Next.js coverage |