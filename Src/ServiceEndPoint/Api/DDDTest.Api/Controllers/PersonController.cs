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
        public async Task<PersonModel> GetPersons([FromHeader]long id,[FromServices] GetPersonByIdService Services)
        {
            var result = Services.Excute(id);
            return await result;
        }
    }
}
