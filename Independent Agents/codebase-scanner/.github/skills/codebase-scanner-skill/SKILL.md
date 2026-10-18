---
name: codebase-scanner-skill
description: "Codebase Scanner skill -- Use when scanning codebases to identify files, functions, and modules affected by a proposed change, tracing call graphs and dependency chains."
---

# Codebase Scanner Skill

**Category:** Tech Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for codebase scanning operations. This skill encapsulates static analysis patterns, dependency tracing, and change impact identification.

## When to Use

- When identifying all files affected by a proposed feature change
- When tracing function call graphs to find impacted code paths
- When detecting shared utilities and cross-cutting concerns
- When listing configuration files that need updating
- When identifying test files that cover affected modules

## Capabilities

- Scan repository structure to identify affected files and directories
- Trace function call graphs to find impacted code paths
- Identify shared utilities, common modules, and cross-cutting concerns
- Detect configuration files that need updating for the change
- Identify test files that need modification or creation
- Map dependency chains (direct and transitive)
- Detect integration points with external systems
- Produce structured impact maps with categorized file lists

## Procedure

1. Parse feature description to identify target modules and entry points
2. Search codebase for files containing target symbols and patterns
3. Trace call graph from entry points to identify all touched functions
4. Identify shared modules used by affected code
5. Map transitive dependencies (what depends on what we're changing)
6. List configuration and environment files needing updates
7. List existing test files covering affected modules
8. Categorize affected files: direct, dependent, integration, config, test
9. Return structured scan results with confidence scores

## Output Format

Return structured results:

- **Affected Files**: path, change type (modify/create/delete), category
- **Call Graph**: entry points → affected functions → downstream impacts
- **Shared Modules**: common utilities and cross-cutting concerns touched
- **Configuration Impact**: config files needing updates
- **Test Coverage**: existing tests covering affected code, gaps identified
- **Quality Gate**: PASS/FAIL (all critical paths identified with evidence)

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **Static Analysis** | AST parsing, symbol resolution, call graph construction |
| **Dependency Analysis** | Direct and transitive dependency identification |
| **Change Impact Analysis** | IEEE standard for software change impact assessment |
