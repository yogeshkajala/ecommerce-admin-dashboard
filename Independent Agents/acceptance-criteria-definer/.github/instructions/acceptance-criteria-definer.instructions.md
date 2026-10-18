---
description: "Use when defining requirements, writing acceptance criteria, or specifying user stories."
---

# Requirements Standards

## User Story Format
```
As a <role>
I want <capability>
So that <business value>
```

## Acceptance Criteria Format (Given/When/Then)
```
Given <precondition>
When <action>
Then <expected outcome>
```

## Criteria Rules
- Every story must have at least 3 acceptance criteria
- Cover: happy path, error path, edge case (minimum)
- Criteria must be testable — no vague language ("should be fast", "user-friendly")
- Include specific values, thresholds, and measurable outcomes
- Each criterion maps to at least one test case

## Completeness Checklist
- [ ] Functional requirements defined (what the system does)
- [ ] Non-functional requirements defined (performance, security, scalability)
- [ ] Error handling specified (what happens when things fail)
- [ ] Input validation rules specified (allowed values, formats, ranges)
- [ ] Authorization rules specified (who can do what)
- [ ] Data requirements specified (what is stored, retention, format)

## Quality Attributes
- **Measurable**: include numbers (response time < 200ms, 99.9% uptime)
- **Testable**: can be verified with a pass/fail test
- **Unambiguous**: one possible interpretation only
- **Complete**: covers all scenarios including failure modes
- **Traceable**: links to business objective or stakeholder need

## Anti-Patterns (NEVER do)
- "The system should be fast" → Specify: "Response time < 200ms at p95"
- "Handle errors gracefully" → Specify: "Return RFC 7807 error with specific code"
- "Support many users" → Specify: "Handle 1000 concurrent users with < 500ms p99"
- Requirements without acceptance criteria
- Acceptance criteria without testable assertions
