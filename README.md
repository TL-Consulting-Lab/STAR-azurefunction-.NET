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
   ```powershell
   # Install Azure CLI
   winget install Microsoft.AzureCLI
   
   # Install Azure Functions Core Tools
   winget install Microsoft.AzureFunctionsCoreTools
   
   # Install Azurite (requires Node.js)
   npm install -g azurite
   ```

2. Start storage emulator:
   ```powershell
   # Start Azurite in a new terminal
   azurite --silent --location c:\azurite

3. Run the function:
   - Press F5 in VS Code, or
   - Run `func start` in PowerShell terminal

4. Test the function:
   ```powershell
   # Using PowerShell's Invoke-RestMethod
   Invoke-RestMethod "http://localhost:7071/api/HelloWorld?name=YourName"
   
   # Or using Windows curl
   curl.exe "http://localhost:7071/api/HelloWorld?name=YourName"
   ```

### Run on Azure Portal
1. Deploy to Azure:
   ```powershell
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
     
   - Azure Functions require an authentication key by default for security
     https://vanshika-function-app-3pxfkuoee4uo6.azurewebsites.net/api/helloworld?name=Vanshika&code=B4l1QH2Nhsg5EA6WjrFhNaUE-opahhBVD539r6WYN36hAzFuZ4bnWA==
   - Change the function's authentication level to "anonymous" if you want to access it without a key

3. Test via URL:
   ```powershell
   # Get function URL and key
   $FUNCTION_URL = az functionapp function show --name vanshika-function-app-3pxfkuoee4uo6 --resource-group Demo-functions-.Net --function-name HelloWorld --query "invokeUrlTemplate" -o tsv
   
   # Test the function using PowerShell
   Invoke-RestMethod -Uri "$FUNCTION_URL&name=YourName"
   
   # Alternatively, using curl in PowerShell
   curl.exe "$FUNCTION_URL&name=YourName"
   ```

## Project Structure

```
├── src/                       # Source code files
│   ├── HelloWorld.cs         # HTTP-triggered function
│   └── Program.cs            # Entry point
├── local.settings.json        # Local settings
├── host.json                  # Global settings
├── infra/                     # Infrastructure as Code
│   ├── main.bicep            # Azure resources
│   └── main.parameters.json   # Deployment parameters
└── azure.yaml                 # Azure Developer CLI config
```

## Deploy to Azure

```powershell
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
