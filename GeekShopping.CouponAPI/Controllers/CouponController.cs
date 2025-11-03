using GeekShopping.CouponAPI.Data.ValueObjects;
using GeekShopping.CouponAPI.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.CouponAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CouponController : ControllerBase
    {
        private ICouponRepository _repository;

        public CouponController(ICouponRepository repository)
        {
            _repository = repository ?? throw new
                ArgumentNullException(nameof(repository));
        }

        [HttpGet("{couponCode}")]
        [Authorize]
        public async Task<ActionResult<CouponVO>> FindById(string couponCode)
        {
            //var token = await HttpContext.GetTokenAsync("access_token");
            var coupon = await _repository.GetCouponByCouponCode(couponCode);
            if (coupon == null) return NotFound();
            return Ok(coupon);
        }
    }
}
