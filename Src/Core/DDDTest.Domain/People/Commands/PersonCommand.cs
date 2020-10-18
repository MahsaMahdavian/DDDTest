using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Domain.People.Commands
{
    public class PersonCommand : Command
    {
        public Guid Id { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
    }
}
