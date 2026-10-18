---
description: "Write unit tests with happy path, edge cases, error handling, and coverage targets"
---
# Unit Test Writer Prompt

## Usage
```
@unit-test-writer <describe what to test>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `target` | File or function to write tests for | Yes |
| `framework` | Test framework: pytest, jest, unittest (auto-detect) | No |
| `coverage` | Coverage target percentage (default: 80%) | No |

## Example Invocations

### Test a Module
```
@unit-test-writer Write unit tests for backend/models/transaction_model.py covering all public methods
```

### Test with Edge Cases
```
@unit-test-writer Write tests for UserModel.update_balance() including: zero amount, negative amount, overflow, concurrent access
```

### Coverage Target
```
@unit-test-writer Achieve 90% coverage for backend/routes/transaction_routes.py with mocked database
```

## Tips
- Specify edge cases you want covered (boundary values, null inputs, concurrency)
- Mention if external dependencies should be mocked
- Ask for both happy path and error path tests
