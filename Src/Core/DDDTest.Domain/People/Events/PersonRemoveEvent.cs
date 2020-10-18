using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Domain.People.Events
{
  public  class PersonRemoveEvent:Event
    {
        public PersonRemoveEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}
