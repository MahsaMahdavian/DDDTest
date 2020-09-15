using DDDTest.Domain.People.Contract.Repository;
using DDDTest.Domain.People.Contract.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Services.Person
{
    public class RemovePersonService : IDeletePerson
    {
        private readonly IPeopleRepository _repository;

        public RemovePersonService(IPeopleRepository repository)
        {
            _repository = repository;
        }

        public async Task Excute(int id)
        {
            var person = await _repository.GetByIdAsync(id);
            if (person != null)
                await _repository.Delete(person);

            _repository.Save();
        }
    }
}
