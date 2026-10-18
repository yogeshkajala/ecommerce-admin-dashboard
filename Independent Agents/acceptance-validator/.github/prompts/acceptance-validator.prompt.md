---
description: "Validate implemented features against acceptance criteria with PASS/FAIL evidence"
---
# Acceptance Validator Prompt

## Usage
```
@acceptance-validator <feature or criteria to validate>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `feature` | Feature name or user story to validate | Yes |
| `criteria` | Path to acceptance criteria document or inline criteria | Yes |
| `evidence` | Source of evidence: test results, code, manual verification | No |

## Example Invocations

### Validate Against Criteria
```
@acceptance-validator Validate the transfer feature against the AC in docs/transfer/acceptance-criteria.md
```

### Check Specific Scenario
```
@acceptance-validator Verify that transferring more than account balance returns 400 with "Insufficient balance" error
```

### Full Feature Validation
```
@acceptance-validator Run all Given/When/Then scenarios for user signup and produce a PASS/FAIL report
```

## Tips
- Provide both the criteria document and the implementation files for thorough validation
- Include test output as evidence for automated criteria
- Ask for a summary report with PASS/FAIL per criterion
