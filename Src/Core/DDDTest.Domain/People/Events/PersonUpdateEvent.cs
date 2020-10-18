using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Domain.People.Events
{
   public class PersonUpdateEvent:Event
    {
        public PersonUpdateEvent(Guid id,string firstName,string lastName)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
