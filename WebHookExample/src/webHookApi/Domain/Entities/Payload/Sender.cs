using System;
namespace webHookApi.Domain.Entities.Payload
{
	public class Sender : Entity
	{
        public PayLoad PayLoad { get; set; }
		public Guid PayLoadId { get; set; }

		public int Id { get; set; }

        public string Login { get; set; }

		
	}
}

