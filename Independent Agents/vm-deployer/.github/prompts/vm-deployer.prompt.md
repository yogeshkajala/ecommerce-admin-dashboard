---
description: "Guided prompt for VM Deployer"
---
# VM Deployer Prompt

## Usage
```
@vm-deployer <describe your deployment request>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `target` | The application or service to deploy | Yes |
| `vm_host` | Target VM hostname or IP | Yes |
| `environment` | Deployment environment (dev, staging, production) | No |
| `strategy` | Deployment strategy (rolling, blue-green, canary, recreate) | No |

## Example Invocations

### Basic Usage
```
@vm-deployer Deploy the banking portal to the staging VM at 192.168.1.50
```

### Docker Build + Deploy
```
@vm-deployer Build a Docker image for the backend and deploy to production VM
```

### Health Check After Deploy
```
@vm-deployer Deploy {target} to {vm_host} using {strategy} strategy, verify health check passes
```

## Tips
- Agent will ask for VM details (host, SSH access) via interactive questions if not provided
- Use `strategy: blue-green` for zero-downtime production deployments
- Provide SSH credentials via environment variables, not inline
- The agent builds Docker images locally, transfers via SCP, and runs containers on the target VM
- Always verify health checks pass after deployment before marking complete
