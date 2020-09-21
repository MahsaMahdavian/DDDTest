using DDDtest.Infra.DA.Mapping;
using DDDTest.Domain.People;
using DDDTest.Domain.People.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDtest.Infra.DA
{
    public class PeopleContext:DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PersonMap());
          
        }
        public DbSet<Person> Persons { get; set; }
    }
}
