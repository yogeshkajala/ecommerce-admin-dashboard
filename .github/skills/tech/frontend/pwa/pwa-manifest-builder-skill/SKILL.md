---
description: "PWA Manifest Builder skill -- Creates and configures Web App Manifests for PWAs with proper icons, display modes, shortcuts, and installation behavior"
---

# PWA Manifest Builder Skill

**Category:** Tech Skills > Frontend > PWA

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for PWA Manifest Builder operations using PWA technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for PWA within Frontend development.

## When to Use

- When creating web app manifest for PWA installation
- When configuring PWA display modes and theme colors
- When implementing app shortcuts and share targets
- When PWA-specific technical expertise is required
- When best practices for PWA technology stack must be applied
- When production-grade PWA implementation guidance is needed

## Capabilities

- Create manifest.json with proper icon sets
- Configure display modes: standalone, fullscreen, minimal-ui
- Implement app shortcuts for quick actions
- Set up share target for web share API
- Configure maskable and any-purpose icons

## Procedure

1. Define app identity and display preferences
2. Create icon set in required sizes and formats
3. Configure display mode and orientation
4. Add shortcuts for common actions
5. Set up share target if applicable
6. Validate manifest with Lighthouse PWA audit

## Output Format

Return structured results:

- **Manifest Configuration**
- **Icon Set**
- **Lighthouse Results**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Web App Manifest** | W3C specification for manifest files |
| **Maskable Icons** | Adaptive icon specification for Android |
| **Lighthouse PWA** | PWA audit criteria for installability |

## Anti-Hallucination Rules

- Do not assume all manifest features work across all platforms
- Verify share target support in target browsers
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Icon set covers all required sizes
- Display mode matches application needs
- Manifest passes Lighthouse PWA audit
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow PWA community best practices

## Integration Points

- **Companion Agent**: `@pwa-manifest-builder` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full PWA coverage |
<!-- Technology knowledge base entry for PWA Manifest Builder in PWA Frontend -->
<!-- Technology knowledge base entry for PWA Manifest Builder in PWA Frontend -->