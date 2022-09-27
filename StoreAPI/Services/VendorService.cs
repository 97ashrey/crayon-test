using StoreAPI.Clients;
using StoreAPI.Payloads;

namespace StoreAPI.Services
{
    public class VendorService : IVendorService
    {
        private const double MARK_UP = 1.2;
        private readonly IVendorClient vendorClient;

        public VendorService(IVendorClient vendorClient)
        {
            this.vendorClient = vendorClient;
        }

        public async Task<IList<ProductDTO>> GetProductsAsync()
        {
            IList<ProductDTO> products = await this.vendorClient.GetProductsAsync();

            foreach(ProductDTO product in products)
            {
                product.UnitPrice = Math.Round(product.UnitPrice * MARK_UP, 2);
            }

            return products;
        }
    }
}
