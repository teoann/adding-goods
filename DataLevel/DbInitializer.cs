using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using DataLevel.Entities;

namespace DataLevel
{
    public class DbInitializer: CreateDatabaseIfNotExists<DataContextProducts>
    {
        protected override void Seed(DataContextProducts db)
        {
            #region Products
            Product product1 = new Product { Name = "Cupcake", Price = 25, Count = 10 };
            Product product2 = new Product { Name = "Candy", Price = 10, Count = 30 };
            Product product3 = new Product { Name = "Mafin", Price = 15, Count = 10 };

            db.Products.AddRange(new[] { product1, product2, product3});

            db.SaveChanges();
            #endregion

        }
    }
}
