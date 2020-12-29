using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DDDTest.Domain.People.Entities;
using DDDTest.Services.Interfaces;
using DDDTest.Services.ViewModels;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace DDDTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ApiController
    {
        private readonly IPersonAppService _personAppService;


        public PersonController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        [HttpGet]
        public async Task<PersonViewModel> Get( Guid id)
        {
            return await _personAppService.GetById(id);
        }

        // [HttpGet]
        [HttpGet("SearchPerson")]
        public async Task<IEnumerable< PersonViewModel>> GetAll([FromBody] Expression<Func<Person, bool>> filter)
        {
            return await _personAppService.GetAll(filter);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddPerson([FromBody] PersonViewModel personViewModel)
        {
            return !ModelState.IsValid ? PersonResponse(ModelState) : PersonResponse(await _personAppService.Register(personViewModel));

        }

       
  
        [HttpPost]
        public async Task<IActionResult> UpdatePerson([FromBody] PersonViewModel personViewModel)
        {

            return !ModelState.IsValid ? PersonResponse(ModelState) : PersonResponse(await _personAppService.Update(personViewModel));
           
        }
        [HttpPost]
        public async Task<IActionResult> DeletePerson([FromBody] Guid id)
        {
            return PersonResponse(await _personAppService.Remove(id));

        }
    }
}
