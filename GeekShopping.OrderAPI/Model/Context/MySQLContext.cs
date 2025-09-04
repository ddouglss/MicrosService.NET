using Microsoft.EntityFrameworkCore;

namespace GeekShopping.OrderAPI.Model.Context
{
    public class MySQLContext : DbContext
    {

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {
        }
        public DbSet<OrderDetail> Detail { get; set; }
        public DbSet<OrderHeader> Header { get; set; }
    }
}