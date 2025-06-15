# Azure Function Challenge: Time-Based Greeting

## Objective
Create an Azure Function that provides customized greetings based on local time, deploy it to Azure, and ensure it's properly tested.

## Challenge Steps

### 1. Code Implementation
Modify the Azure Function to:
- Add a feature to provide different greetings based on time:
  - 5:00 AM - 11:59 AM: "Good Morning"
  - 12:00 PM - 4:59 PM: "Good Afternoon"
  - 5:00 PM - 9:59 PM: "Good Evening"
  - 10:00 PM - 4:59 AM: "Good Night"

### 2. Testing Requirements
Create unit tests to verify:
- Time accuracy
- Correct greeting selection
- HTTP response format
- Error handling

### 3. Azure Deployment
Deploy the function to Azure:
1. Check Azure subscription
```bash
@azure Check subscription details
```

2. Create/verify resources
```bash
@azure Check if function app exists
```

3. Deploy function
```bash
@azure Deploy function and get URL
```

### 4. Documentation
Generate documentation using Copilot:
```bash
/Generate Generate documentation for the time-based greeting function
```
### 5. Create a workflow diagram
Generate a workflow diagram using Copilot

## Success Criteria
1. Function returns correct greetings based on AEST time
2. All unit tests pass
3. Function successfully deployed to Azure
4. Documentation complete and accurate

## Helpful Copilot Commands
```bash
# Get code explanation
/explain Please explain the greeting logic

# Generate unit tests
/tests Generate unit tests for the greeting function

# Check deployment
@azure Check deployment status

# Get function URL
@azure Get function URL
```

## Expected Output Example
```json
{
    "currentTime": "2023-12-25T14:30:00+10:00",
    "greeting": "Good Afternoon",
    "timeZone": "AEST"
}
```
