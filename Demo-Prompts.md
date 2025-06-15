## Azure Function Demo - Copilot Commands
This document lists the various commands used in the Azure Function demo project along with their purposes.

## Code Understanding Commands
1. /explain Please explain this code base

   - Use this command to get a comprehensive explanation of the codebase
   - Helps understand the structure and purpose of the Azure Function

2. /Generate Generate documentation
   - Generates inline documentation for the code
   - Creates detailed comments and explanations within the code

## Deployment and Environment Commands
3.@workspace Provide the deployment information
   - Retrieves deployment-related information
   - Shows configuration and setup requirements

4. @azure Can you check if "vanshika-function-app-3pxfkuoee4uo6" is running in my subscription?
   - Verifies if the function app is running in Azure
   - Checks the deployment status

5. @azure what is the URL of the function?
   - Retrieves the function's endpoint URL
   - Used for testing and integration

6. @azure what is the authention code to access the function?
   - Gets the function access code/key
   - Required for authenticated access

## Local Development Commands
7. Execute this code locally and provide the URL to test
   - Runs the function in local development environment
   - Provides local testing URL

## Code Modification Commands
8. Edit HelloWorld.cs and update This HTTP triggered function executed successfully to Welcome!
   - Change the message "HTTP triggered function executed successfully" to "Welcome!".
   - Modifies time display functionality

9. Edit the functionality to include a Greeting based on the time of the day
   - Adds time-based greeting feature
   - Enhances response message

## Notes
- Commands starting with @azure interact with Azure services
- Commands starting with / are for code generation and documentation
- Local execution commands help in testing before deployment
