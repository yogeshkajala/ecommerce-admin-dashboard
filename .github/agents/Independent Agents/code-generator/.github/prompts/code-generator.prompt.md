---
description: "Generate production-quality code following project conventions and SOLID principles"
---
# Code Generator Prompt

## Usage
```
@code-generator <describe what to build>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `component` | What to generate: endpoint, model, service, controller | Yes |
| `spec` | Requirements, API contract, or architecture description | Yes |
| `language` | Programming language (auto-detected if omitted) | No |
| `pattern` | Architecture pattern: MVC, layered, clean-arch | No |

## Example Invocations

### Generate an Endpoint
```
@code-generator Create a new FastAPI endpoint for account statements with date filtering and pagination
```

### Generate a Model
```
@code-generator Generate a SQLite model for notifications with fields: id, user_id, message, read_status, created_at
```

### Generate from Spec
```
@code-generator Implement the /api/admin/users endpoint from the OpenAPI spec in docs/api-contract.yaml
```

## Tips
- Reference existing files so generated code follows the same conventions
- Specify error handling expectations (what errors, what status codes)
- Mention if you want tests generated alongside the code
