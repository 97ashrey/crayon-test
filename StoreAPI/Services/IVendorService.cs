using StoreAPI.Payloads;

namespace StoreAPI.Services
{
    public interface IVendorService
    {
        Task<IList<ProductDTO>> GetProductsAsync();
    }
}
