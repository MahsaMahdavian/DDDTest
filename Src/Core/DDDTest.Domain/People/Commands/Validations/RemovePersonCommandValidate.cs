using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Domain.People.Commands.Validations
{
    public class RemovePersonCommandValidate:PersonValidation<RemovePersonCommand>
    {
        public RemovePersonCommandValidate()
        {
            ValidateId();
        }
    }
}
