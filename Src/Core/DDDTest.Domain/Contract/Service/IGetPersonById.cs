using DDDTest.Domain.Person;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Domain.Contract.Service
{
    public interface IGetPersonById
    {
        Task<PersonModel> Excute(long id);
    }
}
