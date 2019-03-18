using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLevel.Entities;

namespace DataLevel.Repositories
{
    public class RepositoryProducts : IRepositoryProducts
    {
        public async Task<List<Product>> GetProductsAsync()
        {
            var result = new List<Product>();

            using (var context = new DataContextProducts())
            {
                result = await context.Products.ToListAsync();
            }

            return result;
        }
        public async Task<Product> GetProductAsync(int id)
        {
            var Product = new Product();
            using (var context = new DataContextProducts())
            {
                Product = await Task.Run(() => context.Products.FirstOrDefault(f => f.ProductId == id));
            }
            return Product;
        }
        public async Task<Product> AddProductAsync(Product Product)
        {
            Product result;
            using (var context = new DataContextProducts())
            {
                result = context.Products.Add(Product);//нужно ли делать операцию ассинхронно?
                await context.SaveChangesAsync();
            }
            return result;
        }
        public async Task DeleteProductAsync(int id)
        {
            using (var context = new DataContextProducts())
            {
                var Product = await context.Products.FirstOrDefaultAsync(f => f.ProductId == id);
                context.Entry(Product).State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }
        public async Task<Product> UpdateProductAsync(Product Product)
        {
            using (var context = new DataContextProducts())
            {
                context.Entry(Product).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
            return Product;
        }
    }
}
