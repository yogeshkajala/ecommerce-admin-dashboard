---
description: "Guided prompt for Defect Lifecycle Manager"
---
# Defect Lifecycle Manager Prompt

## Usage
```
@defect-lifecycle-manager <describe your request>
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
@defect-lifecycle-manager Analyze the target system and provide recommendations
```

### Targeted Analysis
```
@defect-lifecycle-manager Review {target} with {scope} scope and return {format} output
```

## Tips
- Provide specific file paths or component names for targeted analysis
- Use `scope: incremental` for change-focused reviews
- Combine with other agents for cross-domain analysis
