using System;
using Microsoft.EntityFrameworkCore;
using webHookApi.Domain.Entities;

namespace webHookApi.Infrastructure.Respositories.Implementation
{
	public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
	{
        private readonly ApplicationDbContext _DbContext;
        private readonly DbSet<TEntity> _DbSet;

        public RepositoryBase(ApplicationDbContext dbContext)
		{
            _DbContext = dbContext;
            _DbSet = dbContext.Set<TEntity>();
		}

        public async Task<bool> AddAsync(TEntity entity)
        {
            await _DbSet.AddAsync(entity);
            var count = await _DbContext.SaveChangesAsync();

            return count > 0 ? true : false;
        }
    }
}

