namespace GeekShopping.ProductAPI.Data.ValueObjects
{
    public class ProductVo
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }

    }
}
