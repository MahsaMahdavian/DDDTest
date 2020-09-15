﻿using DDDTest.Domain.People.Contract.Repository;
using DDDTest.Domain.People.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DDDtest.Infra.DA.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>, IDisposable where TEntity : class
    {

        // public readonly UnitOfWork UnitOfWork;
        private PeopleContext _context;
        private readonly DbSet<TEntity> dbSet;
        public BaseRepository(PeopleContext Context)
        {
            Context = _context;
            dbSet = _context.Set<TEntity>();

        }
        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);

        }

        public async Task Update(TEntity entity)
        {
            dbSet.Update(entity);

        }

        public async Task Delete(TEntity entity)
        {
            dbSet.Remove(entity);

        }

        public async Task<IEnumerable<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
          

            if (filter != null)
            {
                query = query.Where(filter);
            }

         
            return await query.ToListAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

      
    }
}
