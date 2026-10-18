---
description: "REST API Designer skill -- Designs RESTful APIs with proper resource modeling, HTTP method usage, and URL conventions following REST architectural constraints"
---

# REST API Designer Skill

**Category:** Tech Skills > Others > REST API

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for REST API Designer operations using REST API technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for REST API within Others development.

## When to Use

- When designing RESTful API endpoints from requirements
- When implementing proper HTTP method semantics
- When creating API URL structure with resource hierarchy
- When REST API-specific technical expertise is required
- When best practices for REST API technology stack must be applied
- When production-grade REST API implementation guidance is needed

## Capabilities

- Design resource-oriented API endpoints
- Implement proper HTTP method semantics
- Create URL hierarchy for nested resources
- Design query parameters for filtering and pagination
- Implement HATEOAS for API discoverability

## Procedure

1. Analyze domain model and API requirements
2. Design resource URLs and hierarchy
3. Map CRUD operations to HTTP methods
4. Design query parameters and pagination
5. Document API with OpenAPI specification
6. Review API design for consistency

## Output Format

Return structured results:

- **API Design**
- **URL Structure**
- **OpenAPI Specification**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **REST Principles** | RESTful API architectural constraints |
| **HTTP Methods** | Proper use of GET, POST, PUT, PATCH, DELETE |
| **URL Design** | Resource URL naming conventions |

## Anti-Hallucination Rules

- Do not use verbs in URL paths - use nouns for resources
- Verify HTTP method semantics match operation intent
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- API follows REST constraints
- URLs are consistent and predictable
- OpenAPI spec is complete and valid
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow REST API community best practices

## Integration Points

- **Companion Agent**: `@rest-api-designer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full REST API coverage |
<!-- Technology knowledge base entry for REST API Designer in REST API Others -->
<!-- Technology knowledge base entry for REST API Designer in REST API Others -->