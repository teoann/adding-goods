using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataLevel.Entities;
using DataLevel.Repositories;
using BLL.DTOModels;
using AutoMapper;

namespace BLL.Services
{
    public class ProductServise : IProductServise
    {
        private readonly IRepositoryProducts _productRepository;

        public ProductServise(IRepositoryProducts productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductDTO>> GetProductsAsync()
        {
            var pr= await _productRepository.GetProductsAsync();
            var list =  Mapper.Map<List<Product>, List<ProductDTO>>(pr);
            return list;
        }
        public async Task<ProductDTO> GetProductAsync(int id)
        {
            var pr = await _productRepository.GetProductAsync(id);
            var product = Mapper.Map<Product, ProductDTO>(pr);
            return product;
        }
        public async Task<ProductDTO> AddProductAsync(Product product)
        {
            var pr = await _productRepository.AddProductAsync(product);
            var result = Mapper.Map<Product, ProductDTO>(pr);
            return result;
        }
        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteProductAsync(id);
        }

        public async Task<ProductDTO> UpdateProductAsync(Product product)
        {
            var res = await _productRepository.UpdateProductAsync(product);
            var result = Mapper.Map<Product, ProductDTO>(res);
            return result;
        }
    }
}
