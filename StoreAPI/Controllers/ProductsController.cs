using Microsoft.AspNetCore.Mvc;
using StoreAPI.Payloads;
using StoreAPI.Services;

namespace StoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IVendorService vendorService;

        public ProductsController(IVendorService vendorService)
        {
            this.vendorService = vendorService;
        }

        [HttpGet]
        public async Task<IList<ProductDTO>> GetProduct()
        {
            return await this.vendorService.GetProductsAsync();
        }
    }
}
