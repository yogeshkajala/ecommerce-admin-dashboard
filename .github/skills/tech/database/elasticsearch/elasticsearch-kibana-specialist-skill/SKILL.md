---
description: "Elasticsearch Kibana Specialist skill -- Builds Kibana dashboards and visualizations for Elasticsearch data including Lens, Canvas, and alerting configuration"
---

# Elasticsearch Kibana Specialist Skill

**Category:** Tech Skills > Database > Elasticsearch

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Elasticsearch Kibana Specialist operations using Elasticsearch technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Elasticsearch within Database development.

## When to Use

- When building monitoring dashboards with Kibana
- When implementing alerting rules in Kibana
- When creating data visualizations for analytics
- When Elasticsearch-specific technical expertise is required
- When best practices for Elasticsearch technology stack must be applied
- When production-grade Elasticsearch implementation guidance is needed

## Capabilities

- Build dashboards with Lens and Canvas
- Configure Kibana alerts and actions
- Create saved searches and visualizations
- Implement Kibana Spaces for multi-tenancy
- Export and import dashboard configurations

## Procedure

1. Analyze dashboard requirements and data sources
2. Create index patterns for data access
3. Build visualizations with Lens editor
4. Assemble dashboard with proper layout
5. Configure alerts with notification channels
6. Export dashboards for version control

## Output Format

Return structured results:

- **Dashboard Design**
- **Alert Configuration**
- **Export Package**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Kibana Dashboards** | Dashboard design and visualization patterns |
| **Alerting** | Rule types and action configuration |
| **Spaces** | Multi-tenancy and access control |

## Anti-Hallucination Rules

- Do not assume Kibana features match Elasticsearch version exactly
- Verify Kibana feature availability in target version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Dashboards load within acceptable time
- Alerts trigger correctly for defined conditions
- Visualizations accurately represent the data
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Elasticsearch community best practices

## Integration Points

- **Companion Agent**: `@elasticsearch-kibana-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Elasticsearch coverage |
<!-- Technology knowledge base entry for Elasticsearch Kibana Specialist in Elasticsearch Database -->