---
description: "Rust Web Framework Specialist skill -- Builds web applications and APIs with Rust using Actix Web, Axum, or Rocket with proper routing, middleware, and state management"
---

# Rust Web Framework Specialist Skill

**Category:** Tech Skills > Backend > Rust

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Rust Web Framework Specialist operations using Rust technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Rust within Backend development.

## When to Use

- When building web APIs with Actix Web or Axum
- When implementing middleware and extractors for request processing
- When configuring state management and database integration
- When Rust-specific technical expertise is required
- When best practices for Rust technology stack must be applied
- When production-grade Rust implementation guidance is needed

## Capabilities

- Build REST APIs with Axum or Actix Web
- Implement middleware and layers for cross-cutting concerns
- Configure shared state with proper concurrency
- Design extractors for request parsing
- Integrate with SQLx or Diesel for database access

## Procedure

1. Choose web framework based on requirements
2. Design route structure and handler architecture
3. Implement extractors and middleware
4. Configure shared state and database pool
5. Add error handling and response formatting
6. Test with framework-specific test utilities

## Output Format

Return structured results:

- **API Implementation**
- **Middleware Stack**
- **State Configuration**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Axum** | Tower-based web framework patterns |
| **Actix Web** | Actor-based web framework patterns |
| **Tower** | Service and middleware composition |

## Anti-Hallucination Rules

- Do not mix framework-specific patterns between Axum and Actix
- Verify framework version compatibility
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- All endpoints validate input properly
- State is properly shared across handlers
- Error responses are consistent and typed
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Rust community best practices

## Integration Points

- **Companion Agent**: `@rust-web-framework-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Rust coverage |
<!-- Technology knowledge base entry for Rust Web Framework Specialist in Rust Backend -->