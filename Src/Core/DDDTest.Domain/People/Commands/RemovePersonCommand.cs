using DDDTest.Domain.People.Commands.Validations;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Domain.People.Commands
{
    public class RemovePersonCommand:PersonCommand
    {
        public RemovePersonCommand(Guid id)
        {
            Id = id;
            AggregateId = id;

        }
        public override bool IsValid()
        {
            ValidationResult =new RemovePersonCommandValidate().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
