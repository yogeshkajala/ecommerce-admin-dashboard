---
applyTo: "**/*.{py,js,ts,html,css,json}"
---

# Code Generation Standards

## Convention Discovery (CRITICAL — do this FIRST)
Before generating ANY code, auto-discover project conventions by scanning existing files:
1. Detect the tech stack from manifest files (`package.json`, `requirements.txt`, `pom.xml`, `go.mod`, etc.)
2. Find the frontend API client file (look for HTTP call patterns: fetch, axios, $http, HttpClient)
3. Find the backend app entry point (look for route/router registration)
4. Read 2-3 existing route/controller files to learn: decorator style, trailing slash usage, response format
5. Read 2-3 existing model/schema files to learn: naming, structure, validation patterns

Never assume conventions — always read existing code first.

## Full-Stack Consistency (CRITICAL)
- Before writing backend routes, read how the frontend calls APIs (exact URL paths, HTTP methods)
- Before writing frontend API calls, read how backend routes are registered (prefixes, trailing slashes)
- **Every frontend API call URL must match a backend route at the EXACT same path**
  - Trailing slashes must match: if one side uses `/loans`, the other must too (not `/loans/`)
  - HTTP methods must match: frontend POST must hit a backend POST endpoint
  - Path parameters must be identical
- When adding a new feature, read BOTH sides of the stack before writing either



## Cross-Layer Checklist (run before finishing code generation)
1. Does every frontend API URL have a matching backend route at the exact path?
2. Do HTTP methods match between frontend calls and backend handlers?
3. Do request body field names match between frontend and backend models?
4. Are new frontend components registered in the app's entry point (script tags, module imports, route config)?
5. Is navigation updated to include the new feature?
6. Is the backend router/controller registered in the main app file?
7. **Smoke-test new routes** using TestClient/httpx with the EXACT URLs the frontend uses (no trailing slash if frontend omits it). If any return 307/405/404, fix the route registration before proceeding.

## Language Standards
- Follow the language's official style guide (PEP-8, ESLint, etc.)
- Use consistent indentation matching existing project files
- Match the import/module style already used in the project

## Error Handling
- Never swallow exceptions silently; always handle with context
- Use structured error responses matching existing project patterns
- Validate input at system boundaries

## Security
- Never hardcode secrets, credentials, or API keys
- Parameterize all database queries; never use string interpolation
- Validate and sanitize all external input at boundaries
