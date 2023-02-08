
namespace webHookApi.Domain.Entities.Payload
{
	public class PayLoad : Entity
	{
		public PayLoad()
		{
			Issue = new Issue();
			RepositoryGit = new RepositoryGit();
			Sender = new Sender();
		}
		public string Action { get; set; }

		public Issue Issue { get; set; }

		public RepositoryGit RepositoryGit { get; set; }

		public Sender Sender { get; set; }
	}
}

