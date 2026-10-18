---
description: "Use when designing APIs, creating OpenAPI specs, defining REST endpoints, GraphQL schemas, or API versioning strategies."
---

# API Design Standards

## REST Conventions
- Use nouns for resources, not verbs: `/users` not `/getUsers`
- Use plural nouns for collections: `/orders` not `/order`
- Nest sub-resources max 2 levels: `/users/{id}/orders`
- Use HTTP methods correctly: GET (read), POST (create), PUT (full update), PATCH (partial), DELETE (remove)

## OpenAPI 3.0
- All new endpoints MUST have an OpenAPI specification
- Include request/response examples for every endpoint
- Define all error responses (400, 401, 403, 404, 409, 422, 500)
- Use `$ref` for shared schemas; never duplicate definitions

## Status Codes
- 200: Success with body
- 201: Created (include Location header)
- 204: Success with no body (DELETE)
- 400: Malformed request (client error)
- 401: Unauthenticated
- 403: Unauthorized (authenticated but forbidden)
- 404: Resource not found
- 409: Conflict (duplicate, state conflict)
- 422: Validation failure (semantically invalid)
- 500: Server error (never expose internals)

## Error Response Format (RFC 7807)
```json
{
  "type": "https://api.example.com/errors/validation",
  "title": "Validation Error",
  "status": 422,
  "detail": "Field 'email' is not a valid email address",
  "instance": "/users/123"
}
```

## Pagination
- Use cursor-based pagination for large datasets
- Include `next`, `prev` links in response
- Default page size: 20, max: 100

## Versioning
- Use URI versioning: `/v1/users`
- Never break existing consumers without a major version bump
- Deprecate with 6-month sunset period and `Sunset` header

## Security
- All endpoints require authentication unless explicitly public
- Use OAuth 2.0 / JWT for authorization
- Rate limit all endpoints; return `429` with `Retry-After` header
- Never expose internal IDs in URLs without authorization checks
