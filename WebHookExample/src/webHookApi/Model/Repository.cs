using System;
using System.Text.Json.Serialization;

namespace webHookApi.Model
{
	public class Repository
	{
		public int Id { get; set; }

		[JsonPropertyName("full_name")]
		public string FullName { get; set; }
	}
}

