# EXPECTATIONS.md

## 4. AI State Persistence
- **The AI Manager Backup PR:** PR #4 (Branch: `chore/tech-manager-setup`) is explicitly designated as a **perpetual open pull request**.
- **Usage:** It acts as the continuous backup stream for the AI Technical Manager's Long-Term Memory (LTM), Team Roster, Rewards ledger, and architectural directives.
- **Rule:** Do not request PR #4 to be merged. Instead, continuously push state updates (e.g., `MEMORY.md` flushes, new `REWARDS.md` entries) to the `chore/tech-manager-setup` branch so the backup is always maintained off-main.