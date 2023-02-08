using System;
namespace webHookApi.Domain.Entities.Payload
{
	public class Issue : Entity
	{
        public PayLoad PayLoad { get; set; }
        public Guid PayLoadId { get; set; }

        public string Url { get; set; }

		public int Number { get; set; }  

		public string Title { get; set; }

    }
}

