using System;
using System.Text.Json.Serialization;
using webHookApi.Domain.Entities.Payload;

namespace webHookApi.Presentation.Payload.Dto
{
	public class PayLoadDto
	{
        public string Action { get; set; }

        public IssueDto Issue { get; set; }

        public SenderDto Sender { get; set; }

        [JsonPropertyName("repository")]
        public RepositoryDto RepositoryGit { get; set; }
    }
}

