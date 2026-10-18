---
name: data-modeler-skill
description: "Data Modeler skill -- Use when designing data models, ERDs, database schemas, domain models, data dictionaries, or migration strategies."
---

# Data Modeler Skill

**Category:** Tech Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for data modeling operations. This skill encapsulates database design patterns, normalization theory, and schema evolution best practices.

## When to Use

- When designing Entity-Relationship Diagrams (ERDs) for new systems
- When creating domain models with aggregates and value objects
- When defining data dictionaries with column specifications
- When designing database normalization or denormalization strategies
- When planning data migrations between schema versions

## Capabilities

- Design Entity-Relationship Diagrams (ERD) in Mermaid format
- Create domain models with aggregates, entities, and value objects
- Define data dictionaries with complete column specifications
- Apply database normalization (1NF through 3NF/BCNF)
- Design denormalization strategies for read performance optimization
- Create data partitioning and sharding strategies
- Map data relationships with cardinality and integrity constraints
- Generate data migration strategies between schema versions
- Design audit trail patterns (created_at, updated_at, soft deletes)

## Procedure

1. Receive data modeling request -- identify domain, entities, and access patterns
2. Analyze requirements for data entities and their relationships
3. Create conceptual model (entities, relationships, cardinality)
4. Design logical model (attributes, data types, constraints, defaults)
5. Normalize to appropriate level (3NF for OLTP, denormalized for analytics)
6. Design indexes for known query patterns and performance requirements
7. Create data dictionary with all field specifications
8. Define data integrity rules, constraints, and triggers
9. Generate ERD in Mermaid format with relationship annotations
10. Document migration strategy if evolving from existing schema

## Output Format

Return structured results:

- **Conceptual Model**: entities, relationships, cardinality overview
- **Logical Model**: tables/collections, columns, types, constraints
- **ERD Diagram**: Mermaid-format entity-relationship diagram
- **Data Dictionary**: field name, type, nullable, default, description
- **Migration Plan**: steps to evolve from current to target schema
- **Quality Gate**: PASS/FAIL with completeness and consistency checks

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **Codd's Normal Forms** | Normalization theory -- 1NF, 2NF, 3NF, BCNF for data integrity |
| **Domain-Driven Design** | Aggregates, bounded contexts, value objects for domain modeling |
| **ISO/IEC 11179** | Metadata registry standard -- naming conventions, data element definitions |
| **Database Per Service** | Microservice data isolation pattern -- schema ownership boundaries |
