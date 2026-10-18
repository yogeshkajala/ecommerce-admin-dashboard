---
description: "Guided prompt for Incident Playbook Writer"
---
# Incident Playbook Writer Prompt

## Usage
```
@incident-playbook-writer <describe your request>
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
@incident-playbook-writer Analyze the target system and provide recommendations
```

### Targeted Analysis
```
@incident-playbook-writer Review {target} with {scope} scope and return {format} output
```

## Tips
- Provide specific file paths or component names for targeted analysis
- Use `scope: incremental` for change-focused reviews
- Combine with other agents for cross-domain analysis
