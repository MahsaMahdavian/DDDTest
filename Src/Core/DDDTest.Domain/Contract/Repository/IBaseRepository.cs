using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Domain.Contract.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id, List<string> joins = null, bool ReadUnCommitted = true);
        Task CreateAsync(TEntity entity);

    }
}
