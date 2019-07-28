#r "Newtonsoft.Json"

using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Collections;
using Newtonsoft.Json;

public static async Task<IActionResult> Run(HttpRequest req, ILogger log)
{
    string message = req.Query["message"];
    string url = "https://outlook.office.com/webhook/9260568e-df73-4b63-9668-6349b3ce05ad@88cb30cf-9982-4b0b-950f-243b551e44ba/IncomingWebhook/6aed418937dc4120b583b23391010f2b/4ee8d085-8181-4c77-9626-44218cc2b583";

    using (HttpClient httpClient = new HttpClient())
    {
    var param = new Hashtable();
    param["Text"] = message;
    var json = JsonConvert.SerializeObject(param);

    var content = new StringContent(json);
    HttpResponseMessage response = await httpClient.PostAsync(url, content);
    }

    return message != null
        ? (ActionResult)new OkObjectResult($"message sent. {message}")
        : new BadRequestObjectResult("Please pass a message on the query string or in the request body");
}
