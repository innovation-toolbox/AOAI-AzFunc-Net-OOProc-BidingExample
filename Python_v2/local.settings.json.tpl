{
    "IsEncrypted": false,
    "Values": {
        "AzureWebJobsStorage": "UseDevelopmentStorage=true",
        "FUNCTIONS_WORKER_RUNTIME": "python",
        "AzureWebJobsFeatureFlags": "EnableWorkerIndexing",
        "AZURE_OPENAI_ENDPOINT": "https://<YOUR-AOAI-ENDPOINT>.openai.azure.com/",
        "AZURE_OPENAI_KEY": "YOUR-AOAI-API-KEY",
        "AZURE_DEPLOYMENT_NAME": "gpt-35-turbo", // <= The type of the model as it is displayed in Azure OpenAI Deployments : Not sure it is being used at all ? 
        "MODEL_NAME": "chat", // <= the model name as it is displayed in Azure OpenAI Deployments
        "TEMPERATURE": 0.7,
        "MAX_TOKENS": 1000,
        "PROMPT": "What is {technology}?"
    }
}