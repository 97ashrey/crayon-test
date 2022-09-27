namespace StoreAPI.Payloads
{
    public class ProductDTO
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public int? MaximumQuantity { get; set; }
    }
}
