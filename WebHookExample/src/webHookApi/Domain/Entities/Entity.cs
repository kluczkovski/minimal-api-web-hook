using System;
namespace webHookApi.Domain.Entities
{
	public class Entity
	{
		public Guid Guid { get; protected set; }

		public Entity()
		{
			Guid = new Guid();
		}
	}
}

