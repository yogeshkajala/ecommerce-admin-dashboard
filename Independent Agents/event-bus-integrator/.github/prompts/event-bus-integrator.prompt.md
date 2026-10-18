---
description: "Guided prompt for Event Bus Integrator"
---
# Event Bus Integrator Prompt

## Usage
```
@event-bus-integrator <describe your request>
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
@event-bus-integrator Analyze the target system and provide recommendations
```

### Targeted Analysis
```
@event-bus-integrator Review {target} with {scope} scope and return {format} output
```

## Tips
- Provide specific file paths or component names for targeted analysis
- Use `scope: incremental` for change-focused reviews
- Combine with other agents for cross-domain analysis
