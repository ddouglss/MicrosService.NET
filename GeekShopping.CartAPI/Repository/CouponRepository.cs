using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.CartAPI.Repository
{
    public class CouponRepository : ICouponRepository
    {
        private readonly MySQLContext _context;
        private readonly IMapper _mapper;

        public CouponRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<CouponVO> GetCouponByCouponCode(string couponCode, string token)
        {
            var coupon = await _context.Coupons.FirstOrDefaultAsync(c => c.CouponCode == couponCode);
            return _mapper.Map<CouponVO>(coupon);
        }
    }
}
