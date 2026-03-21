namespace EcommerceAdmin.Core.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Sku { get; set; } = string.Empty;
        public int StockQuantity { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
