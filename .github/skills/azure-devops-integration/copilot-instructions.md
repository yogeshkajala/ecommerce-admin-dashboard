# GitHub Copilot Custom Instructions for Azure DevOps Integration

These instructions configure Copilot to aid in interacting with Azure DevOps repositories, build pipelines, and work items.

## Azure DevOps CLI & API
- Structure WIQL (Work Item Query Language) queries correctly. Always include filters for `System.State` and `System.AreaPath` when querying work items.
- Reference the correct URL pattern for REST API calls: `https://dev.azure.com/{organization}/{project}/_apis/...`
- Provide `az devops` CLI commands where appropriate:
  *   Create PR: `az boards work-item create --title "Fix bug" --type "Bug"`
  *   List pipelines: `az pipelines list`

## YAML Pipelines Best Practices
- Structure pipeline steps logically, prioritizing caching (`Cache@2`) for NuGet dependencies.
- Utilize task-specific runners (like `DotNetCoreCLI@2` for build, test, and publish) rather than naked bash scripts.
- Secure pipelines: do not hardcode secrets, use variable groups and service connections.
