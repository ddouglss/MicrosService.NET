using GeekShopping.OrderAPI.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.OrderAPI.Model
{
    [Table("order_datail")]
    public class OrderDetail : BaseEntity
    {
        public long OrderHeaderId {  get; set; }

        [ForeignKey("OrderHeaderId")]
        public virtual OrderHeader OrderHeader {  get; set; } // precisa ser virtual
        [Column("ProductId")]
        public long ProductId {  get; set; }
        [Column("count")]
        public int Count { get; set; }
        [Column("product_name")]
        public String ProductName { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
    }
}
