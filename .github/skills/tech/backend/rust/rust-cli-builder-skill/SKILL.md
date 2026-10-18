---
description: "Rust CLI Builder skill -- Builds command-line applications in Rust with clap for argument parsing, indicatif for progress, and cross-platform compatibility"
---

# Rust CLI Builder Skill

**Category:** Tech Skills > Backend > Rust

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Rust CLI Builder operations using Rust technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Rust within Backend development.

## When to Use

- When building CLI tools with argument parsing
- When implementing interactive CLI features with progress bars
- When ensuring cross-platform compatibility for CLI applications
- When Rust-specific technical expertise is required
- When best practices for Rust technology stack must be applied
- When production-grade Rust implementation guidance is needed

## Capabilities

- Parse arguments with clap derive macros
- Build interactive progress indicators with indicatif
- Implement colored output with termcolor
- Design subcommand architectures
- Handle cross-platform file paths and I/O

## Procedure

1. Define CLI structure with subcommands and arguments
2. Implement argument parsing with clap
3. Add interactive features and progress reporting
4. Handle errors with user-friendly messages
5. Test with assert_cmd and predicates
6. Build for multiple platforms

## Output Format

Return structured results:

- **CLI Implementation**
- **Argument Schema**
- **Cross-Platform Tests**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **clap** | Command-line argument parsing patterns |
| **CLI Guidelines** | POSIX and GNU CLI convention compliance |
| **Cross-Platform** | Platform-independent path and I/O handling |

## Anti-Hallucination Rules

- Do not assume terminal capabilities on all platforms
- Verify clap version features in target Rust edition
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- CLI follows POSIX argument conventions
- Help text is complete and accurate
- Exit codes are meaningful and documented
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Rust community best practices

## Integration Points

- **Companion Agent**: `@rust-cli-builder` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Rust coverage |
<!-- Technology knowledge base entry for Rust CLI Builder in Rust Backend -->
<!-- Technology knowledge base entry for Rust CLI Builder in Rust Backend -->