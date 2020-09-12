using DDDTest.Domain.People;
using DDDTest.Domain.People.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDtest.Infra.DA.Mapping
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(p => p.FirstName).HasMaxLength(255);
            builder.Property(p => p.LastName).HasMaxLength(255);
        }
    }
}
