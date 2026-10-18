---
description: "Produce effort estimates with PERT analysis, confidence intervals, and work breakdown"
---
# Effort Estimator Prompt

## Usage
```
@effort-estimator <describe the feature or task to estimate>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `feature` | Feature or task description | Yes |
| `team_size` | Number of developers available | No |
| `include_testing` | Include test effort in estimate (default: yes) | No |

## Example Invocations

### Estimate a Feature
```
@effort-estimator Estimate effort for adding scheduled/recurring transfers to the banking portal
```

### With Constraints
```
@effort-estimator Estimate adding OAuth2 login with 2 developers, including E2E tests and documentation
```

### Bug Fix Estimate
```
@effort-estimator How long to fix the transfer sign bug, write regression tests, and validate in staging?
```

## Tips
- Provide scope details (affected modules, dependencies) for accurate estimates
- Mention team familiarity with the tech stack
- Ask for confidence intervals (70% and 90%) for planning purposes
