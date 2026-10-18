---
description: "Define testable acceptance criteria in Given/When/Then format for user stories"
---
# Acceptance Criteria Definer Prompt

## Usage
```
@acceptance-criteria-definer <user story or feature description>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `story` | User story text or Jira key | Yes |
| `context` | Business rules, domain constraints | No |
| `include_nfr` | Include non-functional criteria (performance, security) | No |

## Example Invocations

### From User Story
```
@acceptance-criteria-definer Define AC for: "As a user, I want to transfer money so that I can pay other users"
```

### With Business Rules
```
@acceptance-criteria-definer Define AC for account signup. Rules: min age 18, email must be verified, password min 8 chars
```

### Include NFRs
```
@acceptance-criteria-definer Define AC for the login feature including performance (< 2s response) and security (lockout after 5 failed attempts)
```

## Tips
- Provide the full user story text for complete criteria coverage
- Mention edge cases you care about (e.g., concurrent access, empty inputs)
- Specify if you want Gherkin format, checklist, or table output
