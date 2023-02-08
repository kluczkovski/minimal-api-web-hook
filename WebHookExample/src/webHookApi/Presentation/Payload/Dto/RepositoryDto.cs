using System;
using System.Text.Json.Serialization;

namespace webHookApi.Presentation.Payload.Dto
{
	public class RepositoryDto
	{
        public int Id { get; set; }

        [JsonPropertyName("full_name")]
        public string FullName { get; set; }
    }
}

