﻿using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrascruture.Context
{
    public class DataContext:DbContext
    {
        public DataContext() {}

        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public  DbSet<Transaction> Transactions;

    }
}
