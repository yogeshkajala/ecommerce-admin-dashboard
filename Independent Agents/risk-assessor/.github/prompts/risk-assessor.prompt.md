---
description: "Assess project risks for impact, likelihood, and mitigation planning"
---
# Risk Assessor Prompt

## Usage
```
@risk-assessor <describe the change or project to assess>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `change` | Proposed change, feature, or project description | Yes |
| `scope` | Affected systems or modules | No |
| `threshold` | Risk tolerance: conservative, moderate, aggressive | No |

## Example Invocations

### Change Risk Assessment
```
@risk-assessor Assess risk of refactoring the authentication middleware to use OAuth2
```

### Feature Risk
```
@risk-assessor What are the risks of adding a scheduled transfer feature to the banking portal?
```

### Deployment Risk
```
@risk-assessor Assess deployment risk for pushing the transfer bug fix to production today
```

## Tips
- Include scope and affected systems for accurate blast radius assessment
- Mention deadlines or constraints that affect risk tolerance
- Ask for mitigation strategies alongside the risk matrix
