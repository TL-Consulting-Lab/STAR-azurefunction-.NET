# Azure Functions App

A simple HTTP-triggered Azure Function built with .NET 8 (in-process model).

## Prerequisites

- .NET 8 SDK
- Azure Functions Core Tools v4
- VS Code with Azure Functions extension
- Azure CLI & Azure Developer CLI (azd)
- Azurite (storage emulator)

## Quick Start

### Run Locally
1. Install dependencies:
   ```bash
   brew install azure-cli azure-functions-core-tools@4 azurite
   ```

2. Start storage emulator:
   ```bash
   azurite --silent
   ```

3. Run the function:
   - Press F5 in VS Code, or
   - Run `func start` in terminal

4. Test the function:
   ```bash
   curl "http://localhost:7071/api/HelloWorld?name=YourName"
   ```

### Run on Azure Portal
1. Deploy to Azure:
   ```bash
   azd up
   ```

2. Access the function:
   - Go to [Azure Portal](https://portal.azure.com)
   - Navigate to your Function App
   - Select "Functions" → "HelloWorld"
   - Click "Code + Test"
   - Click "Test/Run"
   - Add parameter: name=YourName
   - Click "Run"

3. Test via URL:
   ```bash
   # Get function URL and key
   FUNCTION_URL=$(az functionapp function show --name vanshika-function-app-3pxfkuoee4uo6 --resource-group Demo-functions-.Net --function-name HelloWorld --query "invokeUrlTemplate" -o tsv)
   
   # Test the function
   curl "$FUNCTION_URL&name=YourName"
   ```

## Project Structure

```
├── HelloWorld.cs              # HTTP-triggered function
├── Program.cs                 # Entry point
├── local.settings.json        # Local settings
├── host.json                  # Global settings
├── infra/                     # Infrastructure as Code
│   ├── main.bicep            # Azure resources
│   └── main.parameters.json   # Deployment parameters
└── azure.yaml                 # Azure Developer CLI config
```

## Deploy to Azure

```bash
azd up
```

## Key Features

- HTTP-triggered function with name parameter
- Azure Bicep infrastructure templates
- Application Insights monitoring
- User-managed identity for security
- HTTPS and function-level auth enabled

## Documentation

- `workflow.md` - Detailed workflow guides
- `PROMPT_GUIDE.md` - Step-by-step creation guide
