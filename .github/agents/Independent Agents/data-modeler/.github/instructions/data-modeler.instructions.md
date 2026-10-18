---
description: "Use when designing database schemas, data models, ERDs, migrations, or data dictionaries."
---

# Data Modeling Standards

## Naming Conventions
- Tables: plural, snake_case (`user_accounts`, `order_items`)
- Columns: singular, snake_case (`first_name`, `created_at`)
- Primary keys: `id` (auto-increment or UUID)
- Foreign keys: `<referenced_table_singular>_id` (`user_id`, `order_id`)
- Indexes: `idx_<table>_<columns>` (`idx_users_email`)
- Constraints: `chk_<table>_<rule>`, `uq_<table>_<columns>`

## Required Fields
- Every table MUST have: `id`, `created_at`, `updated_at`
- Soft delete: use `deleted_at` timestamp (nullable) instead of hard deletes
- Audit: include `created_by`, `updated_by` for business-critical tables

## Normalization
- Normalize to 3NF for OLTP systems
- Denormalize only for proven read-performance bottlenecks with documentation
- Document denormalization decisions with rationale

## Constraints
- All foreign keys must have explicit ON DELETE/ON UPDATE actions
- NOT NULL by default; nullable only with documented reason
- Use CHECK constraints for enum-like fields
- Unique constraints for natural keys (email, username, etc.)

## Migrations
- Always create reversible migrations (up AND down)
- Never drop columns in the same release as code removal
- Add columns as nullable first, backfill, then add NOT NULL
- Test rollback before merging migration PRs
- One logical change per migration file

## Performance
- Index all foreign keys
- Index columns used in WHERE, ORDER BY, JOIN
- Avoid indexes on low-cardinality columns
- Use partial indexes for frequently filtered subsets
