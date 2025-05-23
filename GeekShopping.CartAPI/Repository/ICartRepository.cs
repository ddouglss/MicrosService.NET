﻿using GeekShopping.CartAPI.Model.Data.ValueObjcts;

namespace GeekShopping.CartAPI.Repository
{
    public interface ICartRepository
    {
        Task <CartVO> FindCartByUserId (string userId);
        Task<CartVO> SaveOrUpDateCart ( CartVO cart );
        Task<bool> RemoveFromCart (long cartDetailsId);
        Task<bool> ApplyCoupon(string userId, string couponCode);
        Task<bool> RemoveCoupon (string userId);
        Task<bool> ClearCart(string userId);
    }
}
