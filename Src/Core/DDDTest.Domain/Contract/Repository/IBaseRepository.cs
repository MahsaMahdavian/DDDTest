using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Domain.Contract.Repository
{
   public  interface IBaseRepository<TEntity>:ITransactionalRepository where TEntity:class
    {
        TEntity GetById(long id, List<string> joins = null, bool ReadUnCommitted = true);
        Task<TEntity> GetByIdAsync(long id, List<string> joins = null, bool ReadUnCommitted = true);

    }
}
