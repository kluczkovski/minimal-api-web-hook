using System;
using System.Text.Json.Serialization;

namespace webHookApi.Domain.Entities.Payload
{
	public class RepositoryGit : Entity
	{
		public PayLoad PayLoad { get; set; }
		public Guid PayLoadId { get; set; }

		public int Id { get; set; }

		public string FullName { get; set; }

	}
}

