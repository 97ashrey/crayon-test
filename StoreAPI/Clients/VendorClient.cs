using StoreAPI.Payloads;

namespace StoreAPI.Clients
{
    public class VendorClient : IVendorClient
    {
        private IHttpClientFactory httpClientFactory;

        public VendorClient(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<IList<ProductDTO>> GetProductsAsync()
        {
            HttpClient client = this.GetVendorClient();

            IList<ProductDTO>? products = await client.GetFromJsonAsync<IList<ProductDTO>>("/api/products");

            if (products is null)
            {
                return new List<ProductDTO>();
            }

            return products;
        }

        private HttpClient GetVendorClient()
        {
            return this.httpClientFactory.CreateClient(HttpClientNames.VENDOR_CLIENT_NAME);
        }
    }
}
