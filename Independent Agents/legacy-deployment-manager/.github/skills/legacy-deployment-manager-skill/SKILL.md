---
description: "Legacy Deployment Manager skill -- Use when managing legacy migration deployment including cutover planning, parallel run coordination, data synchronization, and fallback procedures."
---
# Legacy Deployment Manager Skill

## Purpose
Provides domain-specific knowledge and step-by-step procedures for Legacy Deployment Manager operations.

## When to Use
- When performing deployment tasks that require specialized knowledge
- When structured output and validated results are needed
- When domain best practices and industry standards must be applied

## Capabilities
- Plan and execute deployment strategies (blue-green, canary, rolling, recreate)
- Validate pre-deployment readiness checks including health probes and config verification
- Orchestrate rollback procedures with automatic failure detection triggers
- Manage deployment artifacts, versioning, and environment promotion workflows
- Monitor deployment health metrics during and after release windows
- Coordinate approval gates and change advisory board (CAB) sign-offs
- Generate deployment runbooks with step-by-step execution procedures
- Verify post-deployment smoke tests and synthetic transaction validation

## Procedure
1. Receive deployment request -- validate artifact version, target environment, and change ticket
2. Execute pre-deployment checks -- verify health probes, config completeness, and dependency availability
3. Review deployment strategy (blue-green, canary, rolling) against risk profile and SLA requirements
4. Execute deployment according to strategy -- monitor progress at each stage gate
5. Run post-deployment smoke tests and synthetic transactions to verify functionality
6. Monitor deployment health metrics (error rate, latency, saturation) for stability window
7. Execute rollback if health metrics breach defined thresholds during stability window
8. Generate deployment report with timeline, metrics, issues encountered, and final status

## Output Format
Return structured results:
- **Deployment Status**: SUCCESS/FAILED/ROLLED_BACK with timeline
- **Health Metrics**: error rate, latency p50/p95/p99, throughput during deployment
- **Validation Results**: smoke test outcomes, synthetic transaction results
- **Rollback Details**: trigger reason, rollback duration, recovery confirmation (if applicable)
- **Change Record**: deployment ID, artifact version, environment, approvals

## Industry Standards
| Standard | Relevance |
|----------|-----------|
| **DORA Metrics** | Deployment frequency, lead time, change failure rate, MTTR benchmarks |
| **ITIL Change Management** | Change categorization, approval workflows, and post-implementation review |
| **12-Factor App** | Build/release/run separation, config management, and disposability |

## Anti-Hallucination Rules
- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER confirm deployment success without health check verification
- ALWAYS verify rollback procedures exist before executing deployments
