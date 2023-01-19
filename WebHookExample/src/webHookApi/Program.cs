using webHookApi.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/payload", async (HttpRequest request) =>
{
    app.Logger.Log(LogLevel.Information, "Starting payload");

    var payload = await request.ReadFromJsonAsync<Payload>();
    app.Logger.Log(LogLevel.Information, $"Payload Action: {payload?.Action}");
    app.Logger.Log(LogLevel.Information, $"Payload Issue Title: {payload?.Issue.Title}");
    app.Logger.Log(LogLevel.Information, $"Payload Issue url: {payload?.Issue.Url}");
    app.Logger.Log(LogLevel.Information, $"Payload Repository Name : {payload?.Repository.FullName}");

    app.Logger.Log(LogLevel.Information, "Ending payload");

    Results.Ok();
});

app.Run();
