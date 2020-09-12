using DDDTest.Domain.People.Contract.Repository;
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
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class 
    {

        public readonly UnitOfWork UnitOfWork;
        private readonly DbSet<TEntity> dbSet;
        public BaseRepository(IUnitOfWork _unitOfWork)
        {
            var unitOfWork = _unitOfWork as UnitOfWork;

            if (unitOfWork == null)
            {
                throw new ArgumentOutOfRangeException("Must be of type EntityFrameworkUnitOfWork");
            }

            dbSet =unitOfWork.GetDbSet<TEntity>();
          
        }



        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await  dbSet.AddAsync(entity);
            UnitOfWork.Commit();
        }

        public void Update(TEntity entity)
        {
            dbSet.Update(entity);
            UnitOfWork.Commit();
        }

        public void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
            UnitOfWork.Commit();
        }

        public IEnumerable<TEntity> list()
        {
            return dbSet.ToList();
        }

        public Task<IEnumerable<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }
    }
}
