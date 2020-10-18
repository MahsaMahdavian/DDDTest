using System;
using System.Collections.Generic;
using System.Text;
using DDDTest.Domain.People.Entities;
using NetDevPack.Data;

namespace DDDTest.Domain.People.Contract.Repository
{
    public interface IPeopleRepository:IBaseRepository<Person>
    {
    }
}
