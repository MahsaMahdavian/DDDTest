using System;
using System.Collections.Generic;
using System.Text;
using DDDTest.Domain.Person;

namespace DDDTest.Domain.Contract.Repository
{
    public interface IPeopleRepository:IBaseRepository<PersonModel>
    {
    }
}
