---
description: "Next.js API Routes Specialist skill -- Builds API routes and server actions in Next.js with proper validation, error handling, and middleware integration"
---

# Next.js API Routes Specialist Skill

**Category:** Tech Skills > Frontend > Next.js

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Next.js API Routes Specialist operations using Next.js technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Next.js within Frontend development.

## When to Use

- When creating API endpoints with Next.js route handlers
- When implementing server actions for form handling
- When adding middleware for authentication and rate limiting
- When Next.js-specific technical expertise is required
- When best practices for Next.js technology stack must be applied
- When production-grade Next.js implementation guidance is needed

## Capabilities

- Build route handlers with GET, POST, PUT, DELETE methods
- Implement server actions with form validation
- Create middleware for request processing
- Handle streaming responses with NextResponse
- Implement API rate limiting and CORS configuration

## Procedure

1. Design API route structure and endpoint hierarchy
2. Implement route handlers with proper HTTP methods
3. Add input validation with Zod or similar
4. Create middleware chain for cross-cutting concerns
5. Handle errors with proper status codes
6. Test API routes with integration tests

## Output Format

Return structured results:

- **API Route Implementation**
- **Validation Schema**
- **Middleware Configuration**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Route Handlers** | Web Request/Response API patterns in Next.js |
| **Server Actions** | Form mutation patterns with server actions |
| **Middleware** | Edge middleware for request processing |

## Anti-Hallucination Rules

- Do not use Pages Router API routes syntax in App Router
- Verify server action availability in the target Next.js version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- All inputs are validated before processing
- Error responses follow consistent format
- Middleware does not block critical paths
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Next.js community best practices

## Integration Points

- **Companion Agent**: `@nextjs-api-routes-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Next.js coverage |