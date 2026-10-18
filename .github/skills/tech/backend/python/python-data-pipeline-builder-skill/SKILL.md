---
description: "Python Data Pipeline Builder skill -- Builds data processing pipelines with Python using pandas, polars, and Apache Beam for ETL operations and data transformation"
---

# Python Data Pipeline Builder Skill

**Category:** Tech Skills > Backend > Python

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Python Data Pipeline Builder operations using Python technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Python within Backend development.

## When to Use

- When building ETL pipelines for data processing
- When transforming large datasets with pandas or polars
- When implementing batch and streaming data pipelines
- When Python-specific technical expertise is required
- When best practices for Python technology stack must be applied
- When production-grade Python implementation guidance is needed

## Capabilities

- Build ETL pipelines with pandas DataFrame operations
- Process large datasets with polars for performance
- Implement Apache Beam pipelines for distributed processing
- Design data validation with Great Expectations
- Create reusable data transformation functions

## Procedure

1. Analyze data sources and transformation requirements
2. Design pipeline stages with proper error handling
3. Implement data extraction from sources
4. Build transformation logic with validation
5. Load processed data to targets
6. Test with sample data and edge cases

## Output Format

Return structured results:

- **Pipeline Implementation**
- **Transformation Logic**
- **Validation Rules**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **pandas Best Practices** | Efficient DataFrame operations and memory management |
| **polars** | High-performance DataFrame operations |
| **Great Expectations** | Data validation and quality checking |

## Anti-Hallucination Rules

- Do not assume pandas operations are always memory-efficient
- Verify library version compatibility for all pipeline stages
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Pipeline handles missing and malformed data
- Memory usage is bounded for large datasets
- Data quality checks validate output correctness
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Python community best practices

## Integration Points

- **Companion Agent**: `@python-data-pipeline-builder` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Python coverage |