---
summary: "Branching Strategy Guide"
description: "Guidelines and procedures for following the team's branching strategy, including branch naming, pull requests, and releases."
---

# SKILL.md - Branching Strategy

This skill helps agents follow the project's branching strategy based on our agreed-upon standards.

## The Golden Rules
- **No Rogue Commits:** Agents must *never* commit directly to the `main` branch.
- **One Branch Per Task:** Whenever an agent pulls a task from the "To Do" column, they must create a feature branch specifically for that task.

## Workflows

1. **Feature Development:**
   - Create a feature branch off the main branch (or the relevant unmerged prerequisite branch).
   - Name the branch `feature/<short-description-of-task>`.
   - Implement the code required to satisfy the Acceptance Criteria.
   - Push the branch and create a Pull Request.
   - **Mandatory Reviewers:** Add `yogeshkajla` (and any other specified reviewers from the active list) as a reviewer to the Pull Request.

2. **Bug Fixes:**
   - Create a bugfix branch.
   - Name the branch `bugfix/<short-description>`.
   - Push and PR.
   - **Mandatory Reviewers:** Add `yogeshkajla` as a reviewer.

3. **Releases:**
   - Merge features into the release branch.
   - Tag the release.
