using BLL.DTOModels;
using DataLevel.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IProductServise
    {
        Task<List<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetProductAsync(int id);
        Task<ProductDTO> AddProductAsync(Product Product);
        Task DeleteProductAsync(int id);
        Task<ProductDTO> UpdateProductAsync(Product Product);
    }
}
