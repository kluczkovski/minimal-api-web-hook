using System;
namespace webHookApi.Domain.Entities.Payload
{
	public class Issue : Entity
	{
        public PayLoadEntity PayLoad { get; set; }
        public Guid PayLoadId { get; set; }

        public string Url { get; set; }

		public int Number { get; set; }  

		public string Title { get; set; }

    }
}

