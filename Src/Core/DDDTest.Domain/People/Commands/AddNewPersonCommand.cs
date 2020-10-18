using DDDTest.Domain.People.Commands.Validations;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Domain.People.Commands
{
    public class AddNewPersonCommand:PersonCommand
    {
        public AddNewPersonCommand(string firstName,String lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override bool IsValid()
        {
            ValidationResult = new AddNewPersonCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }

     
    }
}
