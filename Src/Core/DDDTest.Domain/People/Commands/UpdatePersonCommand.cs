using DDDTest.Domain.People.Commands.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Domain.People.Commands
{
    public class UpdatePersonCommand:PersonCommand
    {
        public UpdatePersonCommand(String firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdatePersonCommandValidate().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
