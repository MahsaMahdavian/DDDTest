using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Domain.Contract.Repository
{
    public interface ITransactionalRepository
    {
        Type DbContextType { get; }
        object GetDbContext();
        void SetDbContext( object dbContext);
    }
}
