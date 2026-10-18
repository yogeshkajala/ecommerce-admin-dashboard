---
description: "Use when performing impact analysis, risk assessment, effort estimation, or codebase scanning for change evaluation."
---

# Impact Analysis Standards

## Codebase Scanning
- Identify ALL files affected by the proposed change
- Map dependency chains (direct and transitive)
- Flag shared utilities, base classes, and common interfaces
- Document integration points that may be affected

## Risk Assessment
- Use 5x5 risk matrix (Likelihood × Impact)
- Score every identified risk with documented justification
- No unmitigated Critical risks allowed to proceed
- High risks require explicit mitigation plan with owner

## Risk Response Tiers
| Tier | Action Required |
|------|----------------|
| Critical | STOP — must mitigate before proceeding |
| High | Mitigation plan required with assigned owner |
| Medium | Accept with monitoring plan |
| Low | Document and accept |

## Effort Estimation
- Break work into tasks ≤ 8 hours each
- Include testing effort (typically 40-60% of development time)
- Account for review cycles and rework
- Add contingency: 20% for known risks, 40% for unknowns

## Change Impact Categories
- **Direct**: Files modified by the change
- **Dependent**: Files that import/reference modified code
- **Integration**: External systems or APIs affected
- **Data**: Database schema or data migration impact
- **Configuration**: Environment or infrastructure changes needed

## Output Requirements
- Affected files list with change type (modify/create/delete)
- Risk register with scores and mitigation strategies
- Effort estimate with confidence level
- Recommendation: proceed / proceed with caution / redesign
