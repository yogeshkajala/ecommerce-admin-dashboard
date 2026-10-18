---
description: "Node.js Middleware Developer skill -- Creates Express and Fastify middleware for request processing including authentication, validation, rate limiting, and error handling"
---

# Node.js Middleware Developer Skill

**Category:** Tech Skills > Backend > Node.js

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Node.js Middleware Developer operations using Node.js technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Node.js within Backend development.

## When to Use

- When building middleware for Express or Fastify applications
- When implementing request validation and sanitization
- When adding rate limiting and request throttling
- When Node.js-specific technical expertise is required
- When best practices for Node.js technology stack must be applied
- When production-grade Node.js implementation guidance is needed

## Capabilities

- Build Express middleware with proper next() handling
- Create Fastify plugins with proper encapsulation
- Implement request validation with Joi or Zod
- Add rate limiting with sliding window algorithm
- Build error handling middleware with proper status codes

## Procedure

1. Identify cross-cutting concerns for middleware
2. Design middleware with single responsibility
3. Implement middleware with proper error propagation
4. Configure middleware ordering
5. Add request validation and sanitization
6. Test middleware in isolation and pipeline

## Output Format

Return structured results:

- **Middleware Implementation**
- **Validation Rules**
- **Error Handling**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Express Middleware** | Express middleware patterns and conventions |
| **Fastify Plugins** | Fastify encapsulated plugin system |
| **OWASP** | Input validation and sanitization standards |

## Anti-Hallucination Rules

- Do not skip calling next() unless intentionally ending the request
- Verify middleware compatibility with the framework version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Middleware handles errors without crashing the process
- Validation rejects malformed input
- Rate limiting prevents abuse without blocking legitimate traffic
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Node.js community best practices

## Integration Points

- **Companion Agent**: `@node-middleware-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Node.js coverage |