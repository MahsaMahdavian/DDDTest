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
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(local);Database=TestDB;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PersonMap());
          
        }
        public DbSet<Person> Persons { get; set; }
    }
}
