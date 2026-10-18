---
description: "Elasticsearch Pipeline Builder skill -- Creates Elasticsearch ingest pipelines for data transformation, enrichment, and normalization during document indexing"
---

# Elasticsearch Pipeline Builder Skill

**Category:** Tech Skills > Database > Elasticsearch

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Elasticsearch Pipeline Builder operations using Elasticsearch technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Elasticsearch within Database development.

## When to Use

- When building ingest pipelines for data transformation
- When enriching documents during indexing with processors
- When normalizing data from multiple sources
- When Elasticsearch-specific technical expertise is required
- When best practices for Elasticsearch technology stack must be applied
- When production-grade Elasticsearch implementation guidance is needed

## Capabilities

- Build ingest pipelines with processor chains
- Implement data enrichment with enrich processor
- Transform data with script, convert, and grok processors
- Handle pipeline failures with on_failure handlers
- Test pipelines with simulate API

## Procedure

1. Analyze data transformation requirements
2. Design pipeline with appropriate processors
3. Implement processor chain with error handling
4. Configure enrich policies for data enrichment
5. Test with pipeline simulate API
6. Monitor pipeline performance and errors

## Output Format

Return structured results:

- **Pipeline Configuration**
- **Processor Chain**
- **Error Handling**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Ingest Pipelines** | Pipeline processor patterns and configuration |
| **Enrich Processor** | Document enrichment during indexing |
| **Grok Processor** | Pattern matching for log parsing |

## Anti-Hallucination Rules

- Do not create pipelines that significantly slow indexing without justification
- Verify processor availability in target Elasticsearch version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Pipeline transforms data correctly
- Error handling captures all failure modes
- Pipeline performance does not degrade indexing throughput
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Elasticsearch community best practices

## Integration Points

- **Companion Agent**: `@elasticsearch-pipeline-builder` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Elasticsearch coverage |