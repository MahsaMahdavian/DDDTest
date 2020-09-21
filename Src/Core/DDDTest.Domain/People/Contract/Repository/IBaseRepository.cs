using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Domain.People.Contract.Repository
{
    public interface IBaseRepository<TEntity>
    {
        Task<TEntity> GetByIdAsync(int id);
        Task CreateAsync(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        Task<IEnumerable<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> filter = null);
        void Save();
    }
}
