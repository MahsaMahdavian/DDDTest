using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DDDTest.Domain.People.Contract.Service;
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
        public async Task<Person> GetPersons([FromHeader] int id, [FromServices] IGetPersonById Services)
        {
            var result = Services.Excute(id);
            return await result;
        }
        [HttpPost("Add")]
        public async Task<string> AddPerson([FromBody] Person person,[FromServices] IAddPerson service)
        {
            if (!string.IsNullOrEmpty(person.FirstName))
            {
             await service.Excute(person);
             return "با موفقیت انجام شد";
            }
            else
                return "خطای خالی بودن اسم شخص";
            
         
        }

        [HttpGet("SearchPerson")]
        public async Task<IEnumerable<Person>> SearchPerson([FromBody] Expression<Func<Person, bool>> filter ,[FromServices] ISearchPerson service)
        {
             return await service.Excute(filter);
        }
        [HttpPost]
        public async Task UpdatePerson([FromBody] int id, [FromServices] IUpdatePerson service)
        {
            await service.Excute(id);
           
        }
        [HttpPost]
        public async Task DeletePerson([FromBody] int id, [FromServices] IDeletePerson service)
        {
            await service.Excute(id);

        }
    }
}
