---
description: "Generate functional and integration tests: E2E scenarios, API tests, and acceptance validation"
---
# Functional Test Writer Prompt

## Usage
```
@functional-test-writer <describe the feature or endpoint to test>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `feature` | Feature or endpoint to write tests for | Yes |
| `test_type` | Test type: e2e, api, integration, acceptance | No |
| `framework` | Test framework: pytest, jest (auto-detect if omitted) | No |

## Example Invocations

### API Tests
```
@functional-test-writer Write API tests for the /api/transfer endpoint covering success, insufficient balance, and invalid recipient
```

### E2E Flow
```
@functional-test-writer Write an E2E test for the full login → transfer → verify balance workflow
```

### From Acceptance Criteria
```
@functional-test-writer Generate tests from these AC: Given a user with $1000 balance, When they transfer $500, Then sender has $500 and recipient gains $500
```

## Tips
- Specify error scenarios and edge cases you want covered
- Reference acceptance criteria for criteria-driven test generation
- Include expected status codes and response formats for API tests
