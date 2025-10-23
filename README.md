# Command Line Chat Test

This is an example project that shows how you can call an Azure AI Foundry LLM chat from a console app.  This give a super easy way to see how you can use these resources in just about any program.

## Setup

Create an Model Deployment in your Azure AI Foundry, then add these three keys to your appSettings.json or your User Secrets, then run the application:

``` bash
{
	"Foundry": {
		"ProjectEndpoint": "https://xxxxxx.services.ai.azure.com/api/projects/lll-oai-service-project",
		"ApiKey": "xxxxx",
		"DeploymentName": "gpt-4o",
	}
}
```
