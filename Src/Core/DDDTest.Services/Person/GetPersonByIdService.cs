using DDDTest.Domain.Contract.Repository;
using DDDTest.Domain.Contract.Service;
using DDDTest.Domain.Person;
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
        public async Task<PersonModel> Excute(long id)
        {
           
           var person =await  _repository.GetByIdAsync(id);
            return person;
        }

       
    }
}
