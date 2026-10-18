---
description: "Elasticsearch Mapping Specialist skill -- Designs Elasticsearch field mappings with proper analyzers, tokenizers, and multi-fields for precise text analysis and search"
---

# Elasticsearch Mapping Specialist Skill

**Category:** Tech Skills > Database > Elasticsearch

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Elasticsearch Mapping Specialist operations using Elasticsearch technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Elasticsearch within Database development.

## When to Use

- When designing field mappings with custom analyzers
- When implementing multi-language search with language analyzers
- When configuring multi-fields for different search behaviors
- When Elasticsearch-specific technical expertise is required
- When best practices for Elasticsearch technology stack must be applied
- When production-grade Elasticsearch implementation guidance is needed

## Capabilities

- Design field mappings with appropriate data types
- Create custom analyzers with tokenizers and filters
- Implement multi-fields for keyword and text search
- Configure language-specific analyzers
- Handle nested and object field mappings

## Procedure

1. Analyze field requirements and search patterns
2. Design mappings with proper field types
3. Create custom analyzers for text processing
4. Configure multi-fields for different query types
5. Test analysis with _analyze API
6. Validate mapping with representative queries

## Output Format

Return structured results:

- **Mapping Configuration**
- **Analyzer Design**
- **Analysis Tests**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Field Mapping** | Data type and field configuration guidelines |
| **Text Analysis** | Analyzer, tokenizer, and filter configuration |
| **Multi-fields** | Multiple mapping types for single fields |

## Anti-Hallucination Rules

- Do not change mapping types on existing fields without reindexing
- Verify analyzer features in target Elasticsearch version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Analyzers produce expected tokens
- Multi-fields support all required query types
- Mapping is compatible with future growth
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Elasticsearch community best practices

## Integration Points

- **Companion Agent**: `@elasticsearch-mapping-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Elasticsearch coverage |