using DDDTest.Domain.People.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Domain.People.Contract.Service
{
    public interface ISearchPerson
    {
        Task<IEnumerable<Person>> Excute(Expression<Func<Person, bool>> filter = null);
    }
}
