﻿using DDDTest.Domain.People.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDTest.Domain.People.Contract.Service
{
   public interface IUpdatePerson
    {
        Task Excute(int id);
    }
}
