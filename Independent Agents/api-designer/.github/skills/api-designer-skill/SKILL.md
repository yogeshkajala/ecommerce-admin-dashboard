---
name: api-designer-skill
description: "API Designer skill -- Use when designing REST API contracts, OpenAPI 3.0 specifications, GraphQL schemas, gRPC protos, or API versioning strategies."
---

# API Designer Skill

**Category:** Tech Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for API design operations. This skill encapsulates technology-specific patterns, RESTful best practices, and API-first design methodology.

## When to Use

- When designing RESTful API endpoints or GraphQL schemas
- When creating OpenAPI 3.0 specifications for new services
- When defining API versioning, pagination, or error response standards
- When designing authentication and authorization flows for APIs
- When evaluating API contracts for consistency and consumer usability

## Capabilities

- Design RESTful API endpoints following resource-oriented architecture
- Create OpenAPI 3.0 specifications with complete schema definitions
- Design GraphQL schemas with types, queries, and mutations
- Create gRPC Protocol Buffer definitions for service communication
- Define API versioning strategies (URI, header, query parameter)
- Design authentication and authorization flows (OAuth 2.0, JWT, API keys)
- Create standardized API error response formats with error codes
- Design pagination, filtering, sorting, and field selection patterns
- Generate API documentation with request/response examples

## Procedure

1. Receive API design request -- identify consumers, use cases, and constraints
2. Analyze domain model to identify resources and relationships
3. Design resource URIs following REST naming conventions
4. Define HTTP methods and status codes for each endpoint
5. Design request/response schemas with validation rules
6. Create error response format with error codes and messages
7. Design authentication/authorization requirements per endpoint
8. Define pagination, filtering, and sorting patterns
9. Generate OpenAPI 3.0 specification with examples
10. Validate specification for completeness and consistency

## Output Format

Return structured results:

- **API Overview**: base URL, versioning strategy, authentication method
- **Endpoints**: method, path, description, request/response schemas
- **Error Catalog**: error code, HTTP status, description, resolution
- **Security Model**: auth flows, scopes, rate limiting rules
- **Quality Gate**: PASS/FAIL with contract completeness evaluation

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **OpenAPI 3.0** | API specification format -- schema definitions, examples, security schemes |
| **REST Maturity Model** | Richardson maturity levels -- resources, HTTP verbs, HATEOAS |
| **OAuth 2.0 / OIDC** | Authorization framework -- flows, scopes, token management |
| **JSON:API** | Response format standard -- pagination, relationships, sparse fieldsets |
| **RFC 7807** | Problem Details for HTTP APIs -- standard error response format |
