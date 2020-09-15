using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DDDTest.Domain.People.Entities;
using DDDTest.Services.Person;
using Microsoft.AspNetCore.Mvc;

namespace DDDTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public async Task<Person> GetPersons([FromHeader] int id, [FromServices] GetPersonByIdService Services)
        {
            var result = Services.Excute(id);
            return await result;
        }
        [HttpPost]
        public async Task<string> AddPerson([FromBody] Person person,[FromServices] AddPersonService service)
        {
            await service.Excute(person);
            return "با موفقیت انجام شد";
        }

        [HttpPost]
        public async Task<IEnumerable<Person>> SearchPerson([FromBody] Expression<Func<Person, bool>> filter ,[FromServices] SearchPersonService service)
        {
             return await service.Excute(filter);
        }

        public async Task UpdatePerson([FromBody] int id, [FromServices] UpdatePersonService service)
        {
            await service.Excute(id);
           
        }

        public async Task DeletePerson([FromBody] int id, [FromServices] RemovePersonService service)
        {
            await service.Excute(id);

        }
    }
}
