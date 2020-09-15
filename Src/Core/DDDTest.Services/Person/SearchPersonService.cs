using DDDTest.Domain.People.Contract.Repository;
using DDDTest.Domain.People.Contract.Service;
using DDDTest.Domain.People.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Services.Person
{
   public class SearchPersonService :ISearchPerson
    {
        private readonly IPeopleRepository _repository;

        public SearchPersonService(IPeopleRepository repository)
        {
            _repository = repository;
        }


        public async Task<IEnumerable<Domain.People.Entities.Person>> Excute(Expression<Func<Domain.People.Entities.Person, bool>> filter = null)
        {
          return  await _repository.FindByConditionAsync(filter);
        }

       
    }
}
