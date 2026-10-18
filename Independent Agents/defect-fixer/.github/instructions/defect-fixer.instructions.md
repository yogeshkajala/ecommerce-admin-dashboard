---
description: "Use when fixing defects, performing root cause analysis (5 Whys, fault tree), implementing minimal-impact fixes, or assessing fix blast radius."
---
# Defect Fixer -- Instructions

## Scope
Use when performing root cause analysis (5 Whys, fault tree), implementing minimal-impact fixes, assessing fix blast radius, or preparing hotfix patches for defects.

## Guidelines
- Always reproduce the defect before attempting a fix
- Apply 5 Whys or fault tree analysis to identify root cause
- Implement minimal-impact fixes that don't introduce regression risk
- Assess blast radius: identify all callers and dependents of changed code
- Write regression tests covering the exact failure scenario
- Never fabricate data -- use only verified information from actual sources

## Quality Standards
- Fixes must include a root cause statement with supporting evidence
- All fixes must have accompanying regression tests
- Blast radius assessment must list affected modules, APIs, and consumers
- Fix PRs must be atomic -- one defect per change, no unrelated refactoring
- Severity classification: Critical (data loss/security), High (feature broken), Medium (degraded), Low (cosmetic)
