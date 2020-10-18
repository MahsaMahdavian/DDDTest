using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDDTest.Domain.People.Events
{
    public class PersonEventHandler :
        INotificationHandler<PersonRegisterEvent>,
        INotificationHandler<PersonUpdateEvent>,
        INotificationHandler<PersonRemoveEvent>

    {

        public Task Handle(PersonRegisterEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
        public Task Handle(PersonUpdateEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        Task INotificationHandler<PersonRemoveEvent>.Handle(PersonRemoveEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
