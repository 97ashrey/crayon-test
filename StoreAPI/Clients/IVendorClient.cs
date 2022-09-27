using StoreAPI.Payloads;

namespace StoreAPI.Clients
{
    public interface IVendorClient
    {
        Task<IList<ProductDTO>> GetProductsAsync();
    }
}
