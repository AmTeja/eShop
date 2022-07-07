using Microsoft.AspNetCore.Mvc;

namespace eShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var result = await _productService.GetProductsAsnyc();
            return Ok(result);
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<Product>> GetProduct(int productId)
        {
            var result = await _productService.GetProductAsync(productId);
            return Ok(result);
        }
    }
}
