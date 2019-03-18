using DataLevel.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLevel.Repositories
{
    public interface IRepositoryProducts
    {
        Task<List<Product>> GetProductsAsync();
        Task<Product> GetProductAsync(int id);
        Task<Product> AddProductAsync(Product Product);
        Task DeleteProductAsync(int id);
        Task<Product> UpdateProductAsync(Product Product);
    }
}
