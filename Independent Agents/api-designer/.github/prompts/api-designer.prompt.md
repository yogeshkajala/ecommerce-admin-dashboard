---
description: "Design REST APIs, OpenAPI specs, GraphQL schemas, and API versioning strategies"
---
# API Designer Prompt

## Usage
```
@api-designer <describe the API you need designed>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `domain` | Business domain or service name | Yes |
| `consumers` | Who consumes this API (frontend, mobile, third-party) | Yes |
| `protocol` | REST, GraphQL, or gRPC | No |
| `auth` | Authentication model: JWT, OAuth2, API-key | No |

## Example Invocations

### Design a REST API
```
@api-designer Design a REST API for user account management with JWT auth
```

### Create OpenAPI Spec
```
@api-designer Generate an OpenAPI 3.0 spec for the transaction endpoints in backend/routes/transaction_routes.py
```

### GraphQL Schema
```
@api-designer Design a GraphQL schema for the banking dashboard with queries for balance, transactions, and statements
```

## Tips
- Specify the consumers (frontend SPA, mobile app, third-party) for tailored design
- Include pagination, filtering, and error response expectations
- Mention existing endpoints if extending an API rather than creating from scratch
