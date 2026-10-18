---
description: "Guided prompt for Continuous Improvement Agent"
---
# Continuous Improvement Agent Prompt

## Usage
```
@continuous-improvement-agent <describe your request>
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
@continuous-improvement-agent Analyze the target system and provide recommendations
```

### Targeted Analysis
```
@continuous-improvement-agent Review {target} with {scope} scope and return {format} output
```

## Tips
- Provide specific file paths or component names for targeted analysis
- Use `scope: incremental` for change-focused reviews
- Combine with other agents for cross-domain analysis
