// Demo of calling an Azure Foundry Chat LLM from a command line program

Console.WriteLine("Chat Service initializing...");

// enter the Azure Foundry Secrets in the Foundry:ProjectEndpoint and Foundry:AgentId in your secrets or appsettings.development.json
(var endpointStr, var apiKey, var modelName, var tenantId) = Utilities.ReadConfig();

// start a conversation with the Chat LLM
await ChatManager.StartChat(endpointStr, apiKey, modelName, tenantId);
