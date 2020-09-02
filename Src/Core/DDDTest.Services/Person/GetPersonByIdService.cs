using DDDTest.Domain.Contract.Repository;
using DDDTest.Domain.Contract.Service;
using DDDTest.Domain.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Services.Person
{
    public class GetPersonByIdService : IGetPersonById
    {
        private readonly IPersonRepository _repository;

        public GetPersonByIdService(IPersonRepository repository)
        {
            _repository = repository;
        }
        public PersonModel Excute(long id)
        {
            throw new NotImplementedException();
            _repository.GetById(id);
        }
    }
}
