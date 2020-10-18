using DDDTest.Domain.People.Entities;
using DDDTest.Services.ViewModels;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Services.Interfaces
{
    public interface IPersonAppService:IDisposable
    {
        Task<IEnumerable<PersonViewModel>> GetAll(Expression<Func<Person, bool>> filter = null);
        Task<PersonViewModel> GetById(Guid Id);


        Task<ValidationResult> Register(PersonViewModel personViewModel);
        Task<ValidationResult> Update(PersonViewModel personViewModel);
        Task<ValidationResult> Remove(Guid id);
    }
}
