using DDDTest.Domain.Contract.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDtest.Infra.DA.Repository
{
    public class BaseRepository<TEntity,TContext> : IBaseRepository<TEntity> where TEntity : class where TContext:DbContext
    {
        protected TContext _Context { get; set; }

        private DbSet<TEntity> dbSet;
        public BaseRepository(TContext Context)
        {
            _Context = Context;
            dbSet = _Context.Set<TEntity>();
        }

      

        public async Task<TEntity> GetByIdAsync(int id, List<string> joins = null, bool ReadUnCommitted = true)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);
           await _Context.SaveChangesAsync();
        }
    }
}
