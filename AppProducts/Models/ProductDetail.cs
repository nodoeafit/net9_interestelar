namespace AppProducts.Models
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        public string Description { get; set; } = string.Empty;

        public int Stock {  get; set; } = 0;

        public decimal? Weight { get; set; }

        public string? Dimensions { get; set; }

        public Product Product { get; set; }

    }
}
