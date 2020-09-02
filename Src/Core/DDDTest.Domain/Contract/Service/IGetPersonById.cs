using DDDTest.Domain.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Domain.Contract.Service
{
    public interface IGetPersonById
    {
        PersonModel Excute(long id);
    }
}
