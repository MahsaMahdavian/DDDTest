using DDDTest.Domain.Contract.Repository;
using DDDTest.Domain.Person;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDtest.Infra.DA.Repository
{
    public class PeopleRepository : BaseRepository<PersonModel, PeopleContext>, IPeopleRepository
    {
        public PeopleRepository(PeopleContext Context) : base(Context)
        {
        }
    }
}
