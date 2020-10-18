using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Domain.People.Commands.Validations
{
    public class UpdatePersonCommandValidate:PersonValidation<UpdatePersonCommand>
    {
        public UpdatePersonCommandValidate()
        {
            ValidateId();
            ValidateFirstName();
            ValidateLastName();
        }
    }
}
