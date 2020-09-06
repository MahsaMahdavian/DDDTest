using DDDTest.Domain.Contract.Repository;
using DDDTest.Domain.Contract.Service;
using DDDTest.Domain.Person;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DDDTest.Services.Person
{
    public class AddPersonModelService : IAddPersonModel
    {
        private readonly IPeopleRepository _repository;
        public AddPersonModelService(IPeopleRepository repository)
        {
            _repository = repository;

        }

        public async Task Excute(PersonModel person)
        {
            await _repository.CreateAsync(person);
          
        }

        
    }
}
