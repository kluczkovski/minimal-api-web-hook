using System;
using webHookApi.Domain.Entities.Payload;
using webHookApi.Infrastructure.Respositories.Implementation;
using webHookApi.Presentation.Payload.Dto;

namespace webHookApi.Presentation.Payload
{
	public static class EntryPointPayload
	{
		public static void Post(this WebApplication app)
		{
            app.MapPost("/payload", async (HttpRequest request, IPayLoadRepository _payloadRepository) =>
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
                    var payLoad = new PayLoad();
                    payLoad.Action = payloadDto.Action;
                    payLoad.Issue.Title = payloadDto.Issue.Title;
                    payLoad.Issue.Url = payloadDto.Issue.Url;
                    payLoad.Issue.Number = payloadDto.Issue.Number;
                    payLoad.RepositoryGit.FullName = payloadDto.RepositoryGit.FullName;
                    payLoad.RepositoryGit.Id = payloadDto.RepositoryGit.Id;
                    payLoad.Sender.Id = payloadDto.Sender.Id;
                    payLoad.Sender.Login = payloadDto.Sender.Login;

                    var temp = await _payloadRepository.AddAsync(payLoad);
                }

                Results.Ok();
            });
        }
	}
}

