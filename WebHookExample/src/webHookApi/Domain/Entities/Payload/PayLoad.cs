
namespace webHookApi.Domain.Entities.Payload
{
	public class PayLoadEntity : Entity
	{
		public PayLoadEntity()
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

