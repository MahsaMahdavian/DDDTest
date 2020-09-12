using DDDTest.Domain.People.Contract.Repository;
using DDDTest.Domain.People.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDtest.Infra.DA.Repository
{
    public class PeopleRepository : BaseRepository<Person>, IPeopleRepository
    {
        public PeopleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
