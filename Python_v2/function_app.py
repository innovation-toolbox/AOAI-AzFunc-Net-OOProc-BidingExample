import azure.functions as func
import datetime
import json
import logging

app = func.FunctionApp()

@app.route(route="whatis/{technology}", methods=["GET"])
@app.text_completion_input(arg_name="response", prompt="%PROMPT%", temperature="%TEMPERATURE%", max_tokens="%MAX_TOKENS%", model = "%MODEL_NAME%")
def whatis(req: func.HttpRequest, response: str) -> func.HttpResponse:
    response_json = json.loads(response)
    return func.HttpResponse(response_json["content"], status_code=200)