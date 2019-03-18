using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using DataLevel.Entities;

namespace DataLevel
{
    public class DataContextProducts: DbContext
    {
        public DataContextProducts(): base("AddingGoods")
        {
            Database.SetInitializer(new DbInitializer());
        }
        public DbSet<Product> Products { get; set; }
    }
}
