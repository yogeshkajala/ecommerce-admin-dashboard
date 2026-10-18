---
description: "Guided prompt for Managed Service Selector"
---
# Managed Service Selector Prompt

## Usage
```
@managed-service-selector <describe your request>
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
@managed-service-selector Analyze the target system and provide recommendations
```

### Targeted Analysis
```
@managed-service-selector Review {target} with {scope} scope and return {format} output
```

## Tips
- Provide specific file paths or component names for targeted analysis
- Use `scope: incremental` for change-focused reviews
- Combine with other agents for cross-domain analysis
