using DDDTest.Domain.People.Entities;
using Microsoft.AspNetCore.Mvc;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Domain.People.Contract.Repository
{
    public interface IBaseRepository<TEntity>:IRepository<Person>
    {
        Task<TEntity> GetByIdAsync(Guid id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task<IEnumerable<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> filter = null);

    }
}
