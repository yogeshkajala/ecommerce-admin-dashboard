---
description: "Guided prompt for Qa Automation Worker"
---
# Qa Automation Worker Prompt

## Usage
```
@qa-automation-worker <describe your request>
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
@qa-automation-worker Analyze the target system and provide recommendations
```

### Targeted Analysis
```
@qa-automation-worker Review {target} with {scope} scope and return {format} output
```

## Tips
- Provide specific file paths or component names for targeted analysis
- Use `scope: incremental` for change-focused reviews
- Combine with other agents for cross-domain analysis
