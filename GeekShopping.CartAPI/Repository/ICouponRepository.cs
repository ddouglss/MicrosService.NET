using GeekShopping.CartAPI.Data.ValueObjcts;

namespace GeekShopping.CartAPI.Repository
{
    public interface ICouponRepository
    {
        Task <CouponVO> GetCouponByCouponCode (string couponCode, string token);
    }
}
