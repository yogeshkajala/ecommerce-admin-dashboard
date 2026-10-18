---
description: "Design database schemas, ERDs, data models, migrations, and data dictionaries"
---
# Data Modeler Prompt

## Usage
```
@data-modeler <describe the data model need>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `entities` | Business entities to model | Yes |
| `engine` | Database engine: SQLite, PostgreSQL, MongoDB | No |
| `output` | Output type: schema, ERD, migration, dictionary | No |

## Example Invocations

### Design Schema
```
@data-modeler Design a schema for notifications with user relationships and read status tracking
```

### Generate Migration
```
@data-modeler Create a migration to add a "scheduled_transfers" table linked to users and accounts
```

### ERD for Existing DB
```
@data-modeler Generate an ERD for the current database schema in backend/database/db.py
```

## Tips
- Specify the database engine for engine-specific syntax
- Include cardinality requirements (one-to-many, many-to-many)
- Mention indexing and performance requirements for large tables
