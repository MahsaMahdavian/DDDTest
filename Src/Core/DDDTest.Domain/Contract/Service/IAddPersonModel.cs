using DDDTest.Domain.Person;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Domain.Contract.Service
{
   public interface IAddPersonModel
    {
       Task Excute(PersonModel person);
    }
}
