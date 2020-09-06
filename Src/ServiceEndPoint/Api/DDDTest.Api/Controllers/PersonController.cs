using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDDTest.Domain.Person;
using DDDTest.Services.Person;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDDTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public async Task<PersonModel> GetPersons([FromHeader] int id, [FromServices] GetPersonByIdService Services)
        {
            var result = Services.Excute(id);
            return await result;
        }
        [HttpPost]
        public async Task<string> addPerson([FromBody] PersonModel person,[FromServices] AddPersonModelService service)
        {
            await service.Excute(person);
            return "با موفقیت انجام شد";
        }
    }
}
