using System.Collections.Generic;
using System.Web.Mvc;
using BLL.Services;
using System.Threading.Tasks;
using DataLevel.Repositories;

namespace GoodsAdding.Controllers
{
    public class ProductsController : Controller
    { 
        private readonly IProductServise _productService;
        
        public ProductsController()
        {
            _productService = new ProductServise(new RepositoryProducts());
        }
        
        // GET: Products
        public async Task<ActionResult> Index()
        {
            var products = await _productService.GetProductsAsync();

            return View(products);
        }
    }
}