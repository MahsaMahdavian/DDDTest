using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DDDTest.Domain.People.Entities
{
   public class Person
    {
        private Person()
        {

        }
        [JsonConstructor]
        public Person(int id,string firstName,string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public int Id { get; set; }
        public string FirstName { get;private set; }
        public string LastName { get; private set; }
    }
}
