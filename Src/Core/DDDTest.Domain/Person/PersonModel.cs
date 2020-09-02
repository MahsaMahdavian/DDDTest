using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DDDTest.Domain.Person
{
   public class PersonModel
    {
        public int id { get; set; }
        [StringLength(255)]
        public string FirstName { get; set; }
        [StringLength(255)]
        public string lastname { get; set; }
    }
}
