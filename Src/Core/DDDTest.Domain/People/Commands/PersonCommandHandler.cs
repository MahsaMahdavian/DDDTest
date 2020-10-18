using DDDTest.Domain.People.Contract.Repository;
using DDDTest.Domain.People.Entities;
using DDDTest.Domain.People.Events;
using FluentValidation.Results;
using MediatR;
using NetDevPack.Data;
using NetDevPack.Messaging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DDDTest.Domain.People.Commands
{
    public class PersonCommandHandler : CommandHandler,
         IRequestHandler<AddNewPersonCommand, ValidationResult>,
         IRequestHandler<RemovePersonCommand, ValidationResult>,
         IRequestHandler<UpdatePersonCommand, ValidationResult>
    {
        private readonly IPeopleRepository _repository;

        public PersonCommandHandler(IPeopleRepository repository)
        {
            _repository = repository;
        }

        public async Task<ValidationResult> Handle(AddNewPersonCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;
            var person = new Person(Guid.NewGuid(), request.FirstName, request.LastName);
            //check for not repeatitive user

            //call event
            person.AddDomainEvent(new PersonRegisterEvent(person.Id, person.FirstName, person.LastName));
            _repository.Create(person);
            return await Commit(_repository.UnitOfWork);

        }

        public async Task<ValidationResult> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;
            var person = new Person(Guid.NewGuid(), request.FirstName, request.LastName);
            //check for not repeatitive user

            //call event
            person.AddDomainEvent(new PersonUpdateEvent(person.Id, person.FirstName, person.LastName));
            _repository.Update(person);
            return await Commit(_repository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(RemovePersonCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;
            var person = await _repository.GetByIdAsync(request.Id);
            if (person is null)
            {
                AddError(" شخص مورد نظر وجود ندارد");
                return ValidationResult;

            }

            person.AddDomainEvent(new PersonRemoveEvent(request.Id));
            _repository.Delete(person);

            return await Commit(_repository.UnitOfWork);
        }
            

    }
}
