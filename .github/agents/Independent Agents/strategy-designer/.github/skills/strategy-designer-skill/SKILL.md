---
description: "Strategy Designer skill -- Design comprehensive test strategy covering all test types and levels."
---
# Strategy Designer Skill

## Purpose
Provides domain-specific knowledge and step-by-step procedures for Strategy Designer operations.

## When to Use
- When performing architecture tasks that require specialized knowledge
- When structured output and validated results are needed
- When domain best practices and industry standards must be applied

## Capabilities
- Evaluate system architecture against established patterns (microservices, event-driven, hexagonal)
- Produce Architecture Decision Records (ADRs) with context, options, and rationale
- Analyze component coupling, cohesion, and dependency graphs
- Design API contracts following REST, GraphQL, or gRPC best practices
- Assess scalability, reliability, and maintainability quality attributes
- Identify architectural anti-patterns and technical debt indicators
- Map data flow and integration boundaries across system components
- Recommend technology stack choices aligned with non-functional requirements

## Procedure
1. Receive architecture request -- identify scope, quality attributes, and constraints
2. Analyze current system structure -- map components, dependencies, and data flows
3. Evaluate architecture against target patterns and quality attribute requirements
4. Identify architectural risks, anti-patterns, and technical debt items
5. Design solution options with trade-off analysis across quality attributes
6. Document architecture decisions in ADR format with context, options, and rationale
7. Validate proposed architecture against non-functional requirements and constraints
8. Produce architecture assessment with diagrams, findings, and recommendations

## Output Format
Return structured results:
- **Architecture Pattern**: identified pattern with confidence score and evidence
- **Component Map**: modules, services, dependencies, and coupling scores
- **Quality Assessment**: scores for scalability, reliability, maintainability, security
- **Anti-Patterns**: identified issues with severity, location, and remediation approach
- **ADR Recommendations**: architectural decisions needed with options and trade-offs

## Industry Standards
| Standard | Relevance |
|----------|-----------|
| **ISO 42010** | Architecture description standard -- viewpoints, perspectives, concerns |
| **TOGAF** | Enterprise architecture framework -- ADM cycle and architecture governance |
| **C4 Model** | Architecture diagramming -- Context, Container, Component, Code levels |

## Anti-Hallucination Rules
- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER make recommendations without supporting evidence or analysis
- ALWAYS verify assumptions against actual system or codebase state
