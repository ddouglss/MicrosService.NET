namespace GeekShopping.CartAPI.Model.Entity
{
    public class Cart
    {
        public CartHeader CartHeader { get; set; }
        public IEnumerable <CartDetail> CartDetails { get; set; }
    }
}
