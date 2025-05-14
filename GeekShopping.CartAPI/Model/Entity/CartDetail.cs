using GeekShopping.CartAPI.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CartAPI.Model.Entity
{
    [Table("cart_datail")]
    public class CartDetail : BaseEntity
    {
        public long CartHeaderId {  get; set; }

        [ForeignKey("CartHeaderId")]
        public virtual CartHeader CartHeader {  get; set; } // precisa ser virtual
        public long ProductId {  get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; } //  precisa ser virtual
        [Column("count")]
        public int Count { get; set; }
    }
}
