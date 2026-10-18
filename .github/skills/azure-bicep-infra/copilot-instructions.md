# GitHub Copilot Custom Instructions for Azure Infrastructure & Deployments

These instructions guide Copilot to write correct, secure, and idiomatic Azure Resource Manager (ARM), Bicep, Terraform, and Azure CLI syntax.

## Bicep/Terraform Standards
- Use the latest API versions for resource declarations.
- Enforce secure defaults: always disable public access on storage/databases unless explicitly requested, use Key Vault references for secrets, and require HTTPS.
- Include resource tagging on all declarations (e.g. `Environment`, `Project`, `Owner`).
- Prefer using Bicep modules to compartmentalize complex architectures (network, compute, database).

## Azure CLI best practices
- Provide correct command parameters and output filters (`--query "[?state=='Running'].id" -o tsv`).
- Highlight standard diagnostic commands such as `az webapp log tail` or `az container logs` to assist in debugging.
