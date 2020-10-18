using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Domain.People.Events
{
   public class PersonRegisterEvent:Event
    {
        public PersonRegisterEvent(Guid id,string firstName,string lastName)
        {
            Id = id;
            FirstName = firstName;
            Lastname = lastName;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
    }
}
