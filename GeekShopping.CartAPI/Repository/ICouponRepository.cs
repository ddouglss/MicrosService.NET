using GeekShopping.CartAPI.Data.ValueObjcts;

namespace GeekShopping.CartAPI.Repository
{
    public interface ICouponRepository
    {
        Task <CouponVO> GetCoupon (string couponCode, string token);
    }
}
