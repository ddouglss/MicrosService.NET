namespace GeekShopping.CartAPI.Model.Data.ValueObjcts
{
    public class CartVO
    {
        public CartHeaderVO CartHeader { get; set; }
        public IEnumerable <CartDetailVO> CartDetails { get; set; }
    }
}
