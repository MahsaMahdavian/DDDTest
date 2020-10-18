using AutoMapper;
using DDDTest.Domain.People.Commands;
using DDDTest.Domain.People.Contract.Repository;
using DDDTest.Domain.People.Entities;
using DDDTest.Services.Interfaces;
using DDDTest.Services.ViewModels;
using FluentValidation.Results;
using NetDevPack.Mediator;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Services.AppServices
{
    public class PersonAppService:IPersonAppService
    {
        private readonly IMapper _mapper;
        private readonly IPeopleRepository _peopleRepository;
        private readonly IMediatorHandler _mediatorHandler;




        public PersonAppService(IMapper mapper,
                                IPeopleRepository peopleRepository,
                                IMediatorHandler mediatorHandler)
        {
            _mapper = mapper;
            _peopleRepository = peopleRepository;
            _mediatorHandler = mediatorHandler;
        }


        public async Task<IEnumerable<PersonViewModel>> GetAll(Expression<Func<Person, bool>> filter = null)
        {
            return _mapper.Map<IEnumerable<PersonViewModel>>( await _peopleRepository.FindByConditionAsync(filter));
        }

        public async Task<PersonViewModel> GetById(Guid Id)
        {
            return _mapper.Map<PersonViewModel>(await _peopleRepository.GetByIdAsync(Id));
        }

        public async Task<ValidationResult> Register(PersonViewModel personViewModel)
        {
            var RegisterCommand = _mapper.Map<AddNewPersonCommand>(personViewModel);
            return await _mediatorHandler.SendCommand(RegisterCommand);
        }

        public async Task<ValidationResult> Update(PersonViewModel personViewModel)
        {
            var UpdateCommand = _mapper.Map<UpdatePersonCommand>(personViewModel);
            return await _mediatorHandler.SendCommand(UpdateCommand);
        }


        public async Task<ValidationResult> Remove(Guid id)
        {
            var RemoveCommand =new RemovePersonCommand(id);
            return await _mediatorHandler.SendCommand(RemoveCommand);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
