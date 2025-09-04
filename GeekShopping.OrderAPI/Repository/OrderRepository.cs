using GeekShopping.OrderAPI.Model;
using GeekShopping.OrderAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.OrderAPI.Repository
{
    public class OrderRepository : IOrdeRepository
    {
        private readonly DbContextOptions<MySQLContext> _context;

        public OrderRepository(DbContextOptions<MySQLContext> context)
        {
            _context = context;
        }

        public async Task<bool> AddOrder(OrderHeader header)
        {
            if (header == null)
                return false;
            await using var _db = new MySQLContext(_context);
            _db.Header.Add(header);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task UpdateOrderPaymentStatus(long orderHeaderId, bool status)
        {
            await using var _db = new MySQLContext(_context);
            var header = await _db.Header.FirstOrDefaultAsync(h => h.Id == orderHeaderId);
            if (header != null)
            {
                header.PaymentStatus = status;
                _db.Header.Update(header);
                await _db.SaveChangesAsync();
            };
        }
    }
}
