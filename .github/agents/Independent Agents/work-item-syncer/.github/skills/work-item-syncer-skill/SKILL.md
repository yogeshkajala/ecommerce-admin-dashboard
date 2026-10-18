---
name: work-item-syncer-skill
description: "Work Item Syncer skill -- Use when creating Jira issues, syncing work items from requirements, building epic/story hierarchies, or performing bulk ticket operations."
---

# Work Item Syncer Skill

**Category:** Domain Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Jira work item synchronization. This skill encapsulates MCP Jira tool patterns, issue hierarchy design, and Markdown formatting for descriptions.

## When to Use

- When creating Jira issues from requirements or design documents
- When building epic → story → sub-task hierarchies
- When syncing work items between external sources and Jira
- When performing bulk ticket operations with proper formatting
- When creating sprints, releases, or linking dependent issues

## Capabilities

- Create individual Jira issues with Markdown-formatted descriptions
- Parse BRD/FRD/user story documents to extract work items
- Build epic + story + sub-task hierarchies automatically
- Set labels, components, fix versions, story points, and custom fields
- Create issue links for dependencies (blocks, is-blocked-by, relates-to)
- Format descriptions using standard Markdown (headings, tables, code blocks)
- Create sprints and add issues to them
- Create releases (fix versions) and assign issues

## Procedure

1. Parse source document or request for work items — extract title, description, type, priority, AC
2. Validate project key exists
3. Map each item to Jira issue type (Epic, Story, Task, Bug, Subtask)
4. Format descriptions using proper multi-line Markdown (never escaped `\n`)
5. Create parent items first (Epics), then children (Stories), then sub-tasks
6. Create issue links for dependencies between items
7. Assign to sprint and fix version if specified
8. Report creation results with success/failure per item

## Output Format

Return structured results:

- **Created Items**: issue key, type, summary, status
- **Hierarchy**: parent-child relationships established
- **Links**: dependency links created between issues
- **Failures**: any items that failed with error details
- **Quality Gate**: PASS/FAIL (all required items created successfully)

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **Jira MCP Tools** | MCP tool interface for Jira (accepts Markdown descriptions) |
| **Agile User Stories** | As a/I want/So that format with acceptance criteria |
| **INVEST Criteria** | Independent, Negotiable, Valuable, Estimable, Small, Testable |
