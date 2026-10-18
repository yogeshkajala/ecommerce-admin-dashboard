---
description: "Guided prompt for Readiness Assessor"
---
# Readiness Assessor Prompt

## Usage
```
@readiness-assessor <describe your request>
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
@readiness-assessor Analyze the target system and provide recommendations
```

### Targeted Analysis
```
@readiness-assessor Review {target} with {scope} scope and return {format} output
```

## Tips
- Provide specific file paths or component names for targeted analysis
- Use `scope: incremental` for change-focused reviews
- Combine with other agents for cross-domain analysis
