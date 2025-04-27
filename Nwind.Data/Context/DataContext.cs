using Nwind.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nwind.Data.Context
{
    public class DataContext:DbContext
    {
        public DbSet <Customers> Customers { get; set; }

        public DbSet <Orders> Orders { get; set; }


        public  DbSet <Products> Products { get; set; }

    }
}
