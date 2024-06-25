using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker.Http;
using System.Net;
using Microsoft.Azure.Functions.Worker.Extensions.OpenAI.TextCompletion;

namespace OpenAiBindings
{
    public class WhatIsClass
    {
        private readonly ILogger<WhatIsClass> _logger;

        public WhatIsClass(ILogger<WhatIsClass> logger)
        {
            _logger = logger;
        }

        [Function(nameof(WhatIs))]
        public static HttpResponseData WhatIs(
            [HttpTrigger(AuthorizationLevel.Function, Route = "whatis/{technology}")] HttpRequestData req,
            // [TextCompletionInput(prompt: "What is {technology}?", Model = "%MODEL_NAME%", Temperature = "%TEMPERATURE%", MaxTokens = "%MAX_TOKENS%")] TextCompletionResponse response)
            [TextCompletionInput(prompt: "What is {technology}?", Model = "%MODEL_NAME%")] TextCompletionResponse response)

        {
            HttpResponseData responseData = req.CreateResponse(HttpStatusCode.OK);
            responseData.WriteString(response.Content);
            return responseData;
        }
    }
}
