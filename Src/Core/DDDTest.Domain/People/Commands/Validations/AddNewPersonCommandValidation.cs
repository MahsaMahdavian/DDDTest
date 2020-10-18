using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Domain.People.Commands.Validations
{
    public class AddNewPersonCommandValidation:PersonValidation<AddNewPersonCommand>
    {
        public AddNewPersonCommandValidation()
        {
            ValidateFirstName();
            ValidateLastName();
            ValidateId();
        }
    }
}
