using DDDTest.Domain.People.Contract.Repository;
using DDDTest.Domain.People.Contract.Service;
using DDDTest.Domain.People;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Services.Person
{
    public class GetPersonByIdService : IGetPersonById
    {
        private readonly IPeopleRepository _repository;

        public GetPersonByIdService(IPeopleRepository repository)
        {
            _repository = repository;
        }
        public async Task<Domain.People.Entities.Person> Excute(int id)
        {
           
          return await  _repository.GetByIdAsync(id);
            
        }

       
    }
}
