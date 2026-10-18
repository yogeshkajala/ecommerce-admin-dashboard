---
description: "Guided prompt for Observability Integrator"
---
# Observability Integrator Prompt

## Usage
```
@observability-integrator <describe your request>
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
@observability-integrator Analyze the target system and provide recommendations
```

### Targeted Analysis
```
@observability-integrator Review {target} with {scope} scope and return {format} output
```

## Tips
- Provide specific file paths or component names for targeted analysis
- Use `scope: incremental` for change-focused reviews
- Combine with other agents for cross-domain analysis
