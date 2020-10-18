using NetDevPack.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DDDTest.Domain.People.Entities
{
   public class Person:Entity, IAggregateRoot
    {
        protected Person()
        {

        }
        [JsonConstructor]
        public Person(Guid id, string firstName,string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
       
        public string FirstName { get;private set; }
        public string LastName { get; private set; }
    }
}
