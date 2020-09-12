using DDDTest.Domain.People.Contract.Repository;
using DDDTest.Domain.People.Contract.Service;
using DDDTest.Domain.People;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DDDTest.Services.Person
{
    public class AddPersonModelService : IAddPerson
    {
        private readonly IPeopleRepository _repository;
        public AddPersonModelService(IPeopleRepository repository)
        {
            _repository = repository;

        }

        public async Task Excute(Domain.People.Entities.Person person)
        {
            await _repository.CreateAsync(person);
          
        }

 
    }
}
