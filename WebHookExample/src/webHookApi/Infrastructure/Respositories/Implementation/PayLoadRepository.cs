using System;
using webHookApi.Domain.Entities.Payload;

namespace webHookApi.Infrastructure.Respositories.Implementation
{
	public class PayLoadRepository : RepositoryBase<PayLoad>, IPayLoadRepository
	{
		public PayLoadRepository(ApplicationDbContext dbContext) : base(dbContext)
		{
		}

    }
}

