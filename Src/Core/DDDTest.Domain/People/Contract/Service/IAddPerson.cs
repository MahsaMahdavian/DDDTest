using DDDTest.Domain.People.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Domain.People.Contract.Service
{
   public interface IAddPerson
    {
       Task Excute(Person person);
    }
}
