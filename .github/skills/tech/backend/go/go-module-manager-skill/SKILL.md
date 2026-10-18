---
description: "Go Module Manager skill -- Manages Go module dependencies with go.mod, workspace mode, and vendoring for reproducible builds and dependency governance"
---

# Go Module Manager Skill

**Category:** Tech Skills > Backend > Go

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Go Module Manager operations using Go technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Go within Backend development.

## When to Use

- When managing Go module dependencies and versions
- When setting up Go workspaces for multi-module development
- When implementing dependency vendoring for reproducible builds
- When Go-specific technical expertise is required
- When best practices for Go technology stack must be applied
- When production-grade Go implementation guidance is needed

## Capabilities

- Configure go.mod with proper module paths
- Manage dependency versions with go get and go mod tidy
- Set up Go workspace with go.work for multi-module repos
- Implement vendoring for offline and reproducible builds
- Resolve dependency version conflicts and replacements

## Procedure

1. Initialize or update go.mod configuration
2. Manage dependencies with proper versioning
3. Set up workspace if multi-module project
4. Configure vendoring if needed
5. Resolve version conflicts with replace directives
6. Validate module graph with go mod verify

## Output Format

Return structured results:

- **Module Configuration**
- **Dependency Graph**
- **Workspace Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Go Modules** | Official module management documentation |
| **Go Workspace** | Multi-module workspace configuration |
| **Semver** | Semantic versioning for Go modules |

## Anti-Hallucination Rules

- Do not manually edit go.sum file
- Verify module features in target Go version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- go.mod is tidy with no unused dependencies
- Module versions are properly pinned
- Vendor directory matches go.mod if vendoring
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Go community best practices

## Integration Points

- **Companion Agent**: `@go-module-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Go coverage |
<!-- Technology knowledge base entry for Go Module Manager in Go Backend -->
<!-- Technology knowledge base entry for Go Module Manager in Go Backend -->