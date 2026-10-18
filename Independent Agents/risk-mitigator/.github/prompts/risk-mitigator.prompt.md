---
description: "Guided prompt for Risk Mitigator"
---
# Risk Mitigator Prompt

## Usage
```
@risk-mitigator <describe your request>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `target` | The file, service, or component to analyze | Yes |
| `scope` | Scope of analysis (full, incremental, targeted) | No |
| `format` | Output format (summary, detailed, json) | No |

## Example Invocations

### Basic Usage
```
@risk-mitigator Analyze the target system and provide recommendations
```

### Targeted Analysis
```
@risk-mitigator Review {target} with {scope} scope and return {format} output
```

## Tips
- Provide specific file paths or component names for targeted analysis
- Use `scope: incremental` for change-focused reviews
- Combine with other agents for cross-domain analysis
