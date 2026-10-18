---
description: "Angular Form Builder skill -- Creates complex reactive and template-driven forms with validation, dynamic form generation, and custom form controls"
---

# Angular Form Builder Skill

**Category:** Tech Skills > Frontend > Angular

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Angular Form Builder operations using Angular technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Angular within Frontend development.

## When to Use

- When building complex multi-step forms with validation
- When creating dynamic form generation from schema definitions
- When implementing custom form controls with ControlValueAccessor
- When Angular-specific technical expertise is required
- When best practices for Angular technology stack must be applied
- When production-grade Angular implementation guidance is needed

## Capabilities

- Build reactive forms with FormBuilder and typed forms
- Implement custom validators and async validators
- Create dynamic forms from JSON schema definitions
- Build custom form controls with ControlValueAccessor
- Handle form arrays for repeatable form sections

## Procedure

1. Analyze form requirements and validation rules
2. Design form model with proper typing
3. Implement form with reactive forms API
4. Add synchronous and asynchronous validators
5. Create custom form controls if needed
6. Test form behavior with ReactiveFormsModule

## Output Format

Return structured results:

- **Form Architecture**
- **Validation Strategy**
- **Custom Controls**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Typed Forms** | Strict typing for form controls and groups |
| **Validation Patterns** | Cross-field validation and async validation best practices |
| **Accessibility** | ARIA attributes and error announcement for form fields |

## Anti-Hallucination Rules

- Do not assume typed forms are available in Angular < 14
- Verify form API changes between Angular versions
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- All form fields have appropriate validation
- Error messages are accessible and descriptive
- Form state is properly managed across steps
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Angular community best practices

## Integration Points

- **Companion Agent**: `@angular-form-builder` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Angular coverage |