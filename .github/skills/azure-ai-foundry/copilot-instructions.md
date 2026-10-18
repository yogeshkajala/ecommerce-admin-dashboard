# GitHub Copilot Custom Instructions for Azure AI Foundry

These instructions guide Copilot to write code, configure endpoints, deploy model endpoints, orchestrate agent flows, and evaluate outputs using the Azure AI SDKs and CLI.

## SDK Usage Guidelines
- Implement the latest `Azure.AI.Projects` preview namespace in C# for Azure AI Foundry Agent Service.
- Use `DefaultAzureCredential` from `Azure.Identity` for passwordless authentication when accessing Azure AI hub resources.
- Follow structured parameters for prompt flow test runs (`pf flow test`).

## Evaluation Setup
- Use standard evaluators (e.g. Groundedness, Relevance, Coherence) and supply proper inputs (`query`, `context`, `response`).
- Do not output plain text evaluations; compile results in JSON or tabular structures for easy programmatic parse.
