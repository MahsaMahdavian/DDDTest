using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Domain.People.Commands.Validations
{
    public class PersonValidation<T>:AbstractValidator<T> where T:PersonCommand
    {
        protected void ValidateFirstName()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("وارد کردن نام الزامی است")
                .Length(2, 150).WithMessage(" تعداد حروف وارد شده باید بین 2و 150 حرف باشد");
        }


        protected void ValidateLastName()
        {
            RuleFor(c => c.LastName).NotEmpty().WithMessage("وارد کردن نام خانوادگی الزامی است")
                .Length(2, 150).WithMessage("تعداد حروف وارد شده باید بین 2و 150 حرف باشد");
        }

        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);

        }
    }
}
