﻿namespace GeekShopping.CartAPI.Model.Data.ValueObjcts
{
    public class CartDetailVO 
    {
        public long Id { get; set; }
        public long CartHeaderId {  get; set; }
        public CartHeaderVO CartHeader {  get; set; }
        public long ProductId {  get; set; }
        public ProductVO Product { get; set; }
        public int Count { get; set; }
    }
}
