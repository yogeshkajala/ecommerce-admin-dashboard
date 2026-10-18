---
description: "Guided prompt for Api Contract Tester"
---
# Api Contract Tester Prompt

## Usage
```
@api-contract-tester <describe your request>
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
@api-contract-tester Analyze the target system and provide recommendations
```

### Targeted Analysis
```
@api-contract-tester Review {target} with {scope} scope and return {format} output
```

## Tips
- Provide specific file paths or component names for targeted analysis
- Use `scope: incremental` for change-focused reviews
- Combine with other agents for cross-domain analysis
