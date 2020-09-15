using DDDTest.Domain.People.Contract.Repository;
using DDDTest.Domain.People.Contract.Service;
using System.Threading.Tasks;

namespace DDDTest.Services.Person
{
    
    public class UpdatePersonService : IUpdatePerson
    {
        private readonly IPeopleRepository _repository;

        public UpdatePersonService(IPeopleRepository repository)
        {
            _repository = repository;
        }
        public async Task Excute(Domain.People.Entities.Person person)
        {
            await _repository.Update(person);
            _repository.Save();
           
        }

        public async Task Excute(int id)
        {
           var person= await _repository.GetByIdAsync(id);
            if (person!=null)         
           await _repository.Update(person);

            _repository.Save();
        }
    }
}
