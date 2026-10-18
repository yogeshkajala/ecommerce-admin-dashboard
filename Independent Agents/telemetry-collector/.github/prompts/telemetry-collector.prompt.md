---
description: "Guided prompt for Telemetry Collector"
---
# Telemetry Collector Prompt

## Usage
```
@telemetry-collector <describe your request>
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
@telemetry-collector Analyze the target system and provide recommendations
```

### Targeted Analysis
```
@telemetry-collector Review {target} with {scope} scope and return {format} output
```

## Tips
- Provide specific file paths or component names for targeted analysis
- Use `scope: incremental` for change-focused reviews
- Combine with other agents for cross-domain analysis
