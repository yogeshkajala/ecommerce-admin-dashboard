---
description: "Rust Memory Safety Specialist skill -- Implements memory-safe Rust code using ownership, borrowing, lifetimes, and smart pointer patterns for zero-cost abstractions"
---

# Rust Memory Safety Specialist Skill

**Category:** Tech Skills > Backend > Rust

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Rust Memory Safety Specialist operations using Rust technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Rust within Backend development.

## When to Use

- When designing Rust data structures with proper ownership
- When resolving borrow checker errors and lifetime issues
- When implementing smart pointer patterns with Box, Rc, Arc
- When Rust-specific technical expertise is required
- When best practices for Rust technology stack must be applied
- When production-grade Rust implementation guidance is needed

## Capabilities

- Design ownership hierarchies for complex data structures
- Resolve lifetime annotations for references
- Implement smart pointers: Box, Rc, Arc, RefCell
- Build interior mutability patterns safely
- Handle self-referential structures with Pin

## Procedure

1. Analyze ownership requirements for data structures
2. Design ownership and borrowing strategy
3. Implement with proper lifetime annotations
4. Choose appropriate smart pointer types
5. Resolve borrow checker errors systematically
6. Test with miri for undefined behavior detection

## Output Format

Return structured results:

- **Ownership Design**
- **Lifetime Annotations**
- **Safety Analysis**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Rust Ownership** | Ownership, borrowing, and lifetime rules |
| **Smart Pointers** | Box, Rc, Arc, and interior mutability patterns |
| **Miri** | Undefined behavior detection tool |

## Anti-Hallucination Rules

- Do not use unsafe blocks without clear justification
- Verify smart pointer features in target Rust edition
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Code compiles without unsafe blocks where possible
- Lifetime annotations are minimal but correct
- No undefined behavior detected by miri
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Rust community best practices

## Integration Points

- **Companion Agent**: `@rust-memory-safety-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Rust coverage |
<!-- Technology knowledge base entry for Rust Memory Safety Specialist in Rust Backend -->