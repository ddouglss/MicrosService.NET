using GeekShopping.OrderAPI.Model;

namespace GeekShopping.OrderAPI.Repository
{
    public interface IOrdeRepository
    {
        Task<bool> AddOrder ( OrderHeader header );
        Task UpdateOrderPaymentStatus (long orderHeaderId, bool status);
    }
}
