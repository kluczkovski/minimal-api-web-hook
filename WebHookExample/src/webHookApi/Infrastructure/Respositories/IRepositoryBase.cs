using System;
using System.Linq.Expressions;
using webHookApi.Domain.Entities;

namespace webHookApi.Infrastructure.Respositories
{
	public interface IRepositoryBase<TEntity> where TEntity : Entity
	{
		/*
        Task<TEntity> GetById(Guid id);

        Task<IEnumerable<TEntity>> GetAll();

		Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>>? filter = null);
		*/

		Task<bool> AddAsync(TEntity entity);

		/*
		Task DeleteAsync(TEntity entity);

		Task Update(TEntity entity);
		*/

	}

}

