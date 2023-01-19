using System;
namespace webHookApi.Model
{
	public class Payload
	{
		public string Action { get; set; }

		public Issue Issue { get; set; }

		public Sender Sender { get; set; }

		public Repository Repository { get; set; }
	}
}

