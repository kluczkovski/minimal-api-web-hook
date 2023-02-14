using System;
using MediatR;
using webHookApi.Application.PayLoad.Commands;
using webHookApi.Domain.Entities.Payload;
using webHookApi.Infrastructure.Respositories.Implementation;
using webHookApi.Presentation.Payload.Dto;

namespace webHookApi.Presentation.Payload
{
	public static class EntryPointPayload
	{
		public static void Post(this WebApplication app)
		{
            app.MapPost("/payload", async (HttpRequest request, IMediator mediator) =>
            {
                app.Logger.Log(LogLevel.Information, "Starting payload");

                var payloadDto = await request.ReadFromJsonAsync<PayLoadDto>();
                app.Logger.Log(LogLevel.Information, $"Payload Action: {payloadDto?.Action}");
                app.Logger.Log(LogLevel.Information, $"Payload Issue Title: {payloadDto?.Issue.Title}");
                app.Logger.Log(LogLevel.Information, $"Payload Issue url: {payloadDto?.Issue.Url}");
                app.Logger.Log(LogLevel.Information, $"Payload Repository Name : {payloadDto?.RepositoryGit.FullName}");

                app.Logger.Log(LogLevel.Information, "Ending payload");

                if (payloadDto != null)
                {
                    var payload = mediator.Send<PayLoadEntity>(new CreatePayLoadCommand(payloadDto));
                }

                Results.Ok();
            });
        }
	}
}

