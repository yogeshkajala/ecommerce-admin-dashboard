---
description: "Python FastAPI Developer skill -- Builds high-performance APIs with FastAPI including Pydantic models, dependency injection, async endpoints, and OpenAPI documentation"
---

# Python FastAPI Developer Skill

**Category:** Tech Skills > Backend > Python

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Python FastAPI Developer operations using Python technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Python within Backend development.

## When to Use

- When building REST APIs with FastAPI and Pydantic
- When implementing async endpoints for I/O-bound operations
- When configuring dependency injection for service layers
- When Python-specific technical expertise is required
- When best practices for Python technology stack must be applied
- When production-grade Python implementation guidance is needed

## Capabilities

- Build API routes with path and query parameters
- Create Pydantic models for request/response validation
- Implement dependency injection with Depends
- Configure async endpoints with database access
- Generate OpenAPI documentation with proper schemas

## Procedure

1. Design API endpoint structure with router organization
2. Create Pydantic models for all request/response types
3. Implement dependency injection for services
4. Build async endpoints with proper error handling
5. Configure OpenAPI metadata and descriptions
6. Test with TestClient and async tests

## Output Format

Return structured results:

- **API Implementation**
- **Pydantic Models**
- **OpenAPI Spec**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **FastAPI Best Practices** | Official FastAPI patterns and async guidelines |
| **Pydantic V2** | Model validation and serialization patterns |
| **OpenAPI 3.1** | API documentation specification |

## Anti-Hallucination Rules

- Do not mix Pydantic V1 and V2 APIs
- Verify FastAPI version features in target environment
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- All endpoints have proper input validation
- Async operations do not block the event loop
- OpenAPI documentation is complete and accurate
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Python community best practices

## Integration Points

- **Companion Agent**: `@python-fastapi-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Python coverage |
<!-- Technology knowledge base entry for Python FastAPI Developer in Python Backend -->