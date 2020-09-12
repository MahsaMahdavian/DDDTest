using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Domain.People.Contract.Repository
{
    public interface IUnitOfWork:IDisposable
    {
           void Commit();
    }
}
