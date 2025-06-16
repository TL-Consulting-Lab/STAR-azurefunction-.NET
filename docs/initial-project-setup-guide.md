# Azure Functions Project Creation Guide

This guide provides the optimal sequence of prompts and steps to create this Azure Functions application seamlessly.

## 1. Initial Project Setup

```plaintext
"Create a new Azure Functions project with .NET 8 using in-process model with an HTTP trigger function named HelloWorld"
```
This will:
- Set up the basic project structure
- Create the initial HTTP trigger function
- Configure the correct .NET version

## 2. Local Development Setup

```plaintext
"Help me set up the local development environment for Azure Functions"
```
This ensures:
- Azure Functions Core Tools installation
- Required VS Code extensions
- Proper local.settings.json configuration

## 3. Storage Emulator and Runtime Configuration

```plaintext
"Configure local storage emulator and runtime settings for the function app"
```

This will set up:

1. Storage Emulator (Azurite):
```bash
# Install Azurite
brew install azurite

# Start Azurite in a terminal
azurite --silent --location /usr/local/var/azurite --debug /usr/local/var/azurite/debug.log
```

2. Configure local.settings.json:
```json
{
    "IsEncrypted": false,
    "Values": {
        "AzureWebJobsStorage": "UseDevelopmentStorage=true",
        "FUNCTIONS_WORKER_RUNTIME": "dotnet",
        "FUNCTIONS_INPROC_NET8_ENABLED": "1"
    }
}
```

Key configurations:
- `AzureWebJobsStorage`: Points to local storage emulator
- `FUNCTIONS_WORKER_RUNTIME`: Set to "dotnet" for .NET runtime
- `FUNCTIONS_INPROC_NET8_ENABLED`: Enables .NET 8 in-process execution

Verification steps:
1. Confirm Azurite is running: `ps aux | grep azurite`
2. Test storage connection: `func azure storage --help`
3. Verify settings in local.settings.json

## 4. Function Implementation

```plaintext
"Update the HelloWorld function to accept a name parameter and return a personalized greeting"
```
This creates:
- Proper input binding
- Parameter validation
- Structured response

## 5. Infrastructure as Code

```plaintext
"Create Bicep templates for deploying the function app to Azure with the following requirements:
- User-assigned managed identity
- Application Insights integration
- Proper storage account configuration
- Function app with .NET 8 runtime"
```
This sets up:
- main.bicep
- main.parameters.json
- Proper resource configurations

## 6. Deployment Configuration

```plaintext
"Set up Azure Developer CLI (azd) configuration for deployment"
```
This creates:
- azure.yaml
- Proper service and environment configurations

## 7. Security Configuration

```plaintext
"Configure security for the function app including:
- Function-level authentication
- HTTPS enforcement
- Managed identity role assignments"
```

## 8. Monitoring Setup

```plaintext
"Set up monitoring and logging for the function app"
```
This configures:
- Application Insights integration
- Log analytics
- Proper diagnostic settings

## 9. Local Testing

```plaintext
"Help me test the function locally"
```
Ensures:
- Function host starts correctly
- Local endpoints work
- Proper response handling

## 10. Deployment

```plaintext
"Deploy the function app to Azure using azd"
```
This:
- Creates resource group
- Deploys all resources
- Configures the function app

## 11. Production Testing

```plaintext
"Help me test the deployed function in Azure"
```
This verifies:
- Production endpoints
- Authentication
- Proper functionality

## Common Issues to Avoid

1. **Authentication Issues**
   - Always get function keys after deployment
   - Use proper authorization level in function attributes

2. **Runtime Issues**
   - Ensure FUNCTIONS_WORKER_RUNTIME is set to "dotnet"
   - Set FUNCTIONS_INPROC_NET8_ENABLED to "1"

3. **Deployment Issues**
   - Verify Azure CLI login status
   - Check resource quotas before deployment
   - Ensure proper role assignments

4. **Local Development Issues**
   - Use proper storage emulator
   - Configure local.settings.json correctly
   - Install all required tools before starting


## Useful Commands

```bash
# Create new function project
func init --worker-runtime dotnet --target-framework net8.0

# Create new function
func new --name HelloWorld --template "HTTP trigger" --authlevel "function"

# Start function locally
func start

# Deploy using azd
azd up

# Get function URL
az functionapp function show --name <app-name> --resource-group <resource-group> --function-name HelloWorld --query "invokeUrlTemplate"
```

## Next Steps

After successful deployment:
1. Set up CI/CD pipelines
2. Implement additional functions
3. Add custom domain and SSL certificates
4. Set up staging environments
