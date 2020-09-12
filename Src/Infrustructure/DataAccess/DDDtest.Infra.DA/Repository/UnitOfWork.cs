using DDDTest.Domain.People.Contract.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDtest.Infra.DA.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        protected PeopleContext _Context { get; set; }

       // private DbSet<TEntity> dbSet;
        public UnitOfWork(PeopleContext Context)
        {
            _Context = Context;
          //  dbSet = _Context.Set<TEntity>();

        }
        internal DbSet<T> GetDbSet<T>() where T : class
        {
            return _Context.Set<T>();
        }

        //internal DbSet GetDbSet(Type type)
        //{
        //    return _Context.Set(type);
        //}
        public void Commit()
        {
            _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
