---
description: "Azure Functions Specialist skill -- Builds serverless applications with Azure Functions including triggers, bindings, and Durable Functions for event-driven architectures"
---

# Azure Functions Specialist Skill

**Category:** Tech Skills > DevOps > Azure

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Azure Functions Specialist operations using Azure technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Azure within DevOps development.

## When to Use

- When building serverless functions with Azure Functions
- When implementing Durable Functions for workflow orchestration
- When configuring triggers and bindings for event processing
- When Azure-specific technical expertise is required
- When best practices for Azure technology stack must be applied
- When production-grade Azure implementation guidance is needed

## Capabilities

- Create functions with HTTP, timer, and queue triggers
- Implement input/output bindings for data access
- Build Durable Functions for orchestration
- Configure host.json for performance tuning
- Set up Application Insights for monitoring

## Procedure

1. Design function app architecture
2. Implement functions with proper triggers
3. Configure bindings for data integration
4. Set up Durable Functions for workflows
5. Configure monitoring with Application Insights
6. Test with Azure Functions Core Tools

## Output Format

Return structured results:

- **Function Implementation**
- **Binding Configuration**
- **Monitoring Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Azure Functions** | Function development best practices |
| **Durable Functions** | Orchestration and entity patterns |
| **Bindings** | Trigger and binding configuration |

## Anti-Hallucination Rules

- Do not assume function execution time limits without checking plan
- Verify function runtime support for target language
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Functions handle cold start gracefully
- Bindings reduce boilerplate code
- Monitoring captures all function executions
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Azure community best practices

## Integration Points

- **Companion Agent**: `@azure-functions-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Azure coverage |
<!-- Technology knowledge base entry for Azure Functions Specialist in Azure DevOps -->