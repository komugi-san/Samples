﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.DomainModels
{

    public class ExpenseDeleteDomainModel
    {

        public ExpenseDeleteDomainModel()
        {
        }

        public Guid Id { get; set; }

        public byte[] RowVersion { get; set; }

    }

}
