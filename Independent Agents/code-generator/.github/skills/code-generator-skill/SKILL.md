---
name: code-generator-skill
description: "Code Generator skill -- Use when generating production-quality code following project conventions, architecture specifications, and SOLID principles."
---

# Code Generator Skill

**Category:** Tech Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for code generation operations. This skill encapsulates language-specific idioms, design patterns, and clean code practices.

## When to Use

- When generating production-quality code from architecture specifications
- When implementing API contracts as service/controller/repository layers
- When applying SOLID principles and clean code patterns
- When generating boilerplate with proper error handling and logging
- When scaffolding new modules following existing project conventions

## Capabilities

- Generate code following project conventions and established patterns
- Implement from architecture specifications and API contracts
- Apply SOLID principles, clean code practices, and DRY principle
- Generate appropriate error handling with structured logging
- Create data models, DTOs, and validation logic
- Implement repository/service/controller patterns as appropriate
- Generate configuration and environment setup
- Produce code that compiles and lints clean on first pass

## Code Standards

| Standard | Rule |
|----------|------|
| Naming | Follow language conventions (camelCase JS, snake_case Python, PascalCase C#) |
| Error Handling | Never swallow exceptions; always log with context |
| Logging | Structured format (JSON); include correlation ID |
| Configuration | Environment variables or config files; never hardcode secrets |
| Dependencies | Pin versions; document purpose of each dependency |
| Comments | Document WHY, not WHAT; public API documentation mandatory |
| Security | Validate input at boundaries; parameterize queries; escape output |

## Procedure

1. Receive generation request -- identify target language, framework, and conventions
2. Read architecture documents to understand component boundaries
3. Read API contracts to understand interface specifications
4. Detect or confirm technology stack and existing conventions
5. For each component:
   a. Create data models and validation logic
   b. Implement business logic in service layer
   c. Create API endpoints matching contract specifications
   d. Add error handling for all failure modes
   e. Add structured logging at appropriate levels
   f. Add configuration for environment-specific values
6. Verify generated code compiles and passes linting
7. Return generated code with file manifest

## Output Format

Return structured results:

- **File Manifest**: list of generated files with descriptions
- **Architecture Conformance**: how code maps to design specifications
- **Dependencies Added**: new packages with version and purpose
- **Configuration Required**: environment variables and config entries needed
- **Quality Gate**: PASS/FAIL with compile/lint status

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **SOLID Principles** | Single responsibility, open/closed, Liskov, interface segregation, DI |
| **Clean Code** | Meaningful names, small functions, no side effects, DRY |
| **12-Factor App** | Config in environment, stateless processes, port binding |
| **OWASP Secure Coding** | Input validation, output encoding, parameterized queries |
