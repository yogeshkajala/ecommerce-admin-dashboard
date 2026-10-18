---
description: "Create Jira issues, sync work items from requirements, and build epic/story hierarchies"
---
# Work Item Syncer Prompt

## Usage
```
@work-item-syncer <describe what to sync or create>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `project` | Jira project key (e.g., WOR) | Yes |
| `source` | Source document or inline requirements | Yes |
| `hierarchy` | Issue hierarchy: epic+stories, flat-stories, tasks | No |

## Example Invocations

### Create from Requirements
```
@work-item-syncer Create Jira stories in WOR from the requirements in docs/scheduled-transfers-brd.md
```

### Single Issue
```
@work-item-syncer Create a bug in WOR: transfer endpoint sign error causing sender balance to increase
```

### Epic with Stories
```
@work-item-syncer Create an epic "Scheduled Transfers" in WOR with stories for: scheduling UI, cron job, notification, cancellation
```

## Tips
- Provide the Jira project key for correct issue creation
- Specify hierarchy (epic → stories → sub-tasks) for structured creation
- Include acceptance criteria in the source for complete story descriptions
