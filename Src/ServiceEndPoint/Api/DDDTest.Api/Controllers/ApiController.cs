using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDTest.Api.Controllers
{
    public abstract class ApiController: ControllerBase
    {
        private readonly ICollection<string> _errors = new List<string>();

        protected ActionResult PersonResponse(object result=null)
        {
            if (IsOperationValid())
                return Ok(result);

            return BadRequest(new ValidationProblemDetails(new Dictionary<string, string[]>

            {
                {"Messages",_errors.ToArray()}

            }));

        }

        protected ActionResult PersonResponse(ModelStateDictionary modelState)
        {
            var errors = modelState.Values.SelectMany(m => m.Errors);
            foreach(var error in errors )
            {
                AddError(error.ErrorMessage);
            }
            return PersonResponse();
        }

        protected  ActionResult PersonResponse(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                AddError(error.ErrorMessage);
            }
            return PersonResponse();
        }
        protected bool IsOperationValid()
        {
            return !_errors.Any();
        }

        protected void AddError(string erro)
        {
            _errors.Add(erro);
        }
        protected void ClearError()
        {
            _errors.Clear();
        }
    }
}
