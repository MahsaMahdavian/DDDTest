using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Domain.People.Contract.Service
{
    public interface IDeletePerson
    {
        Task Excute(int id);
    }
}
