using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Interfaces
{
    public interface IOrderingRepository
    {
        List<Ordering> GetOrderingsByUserId(string id);
    }
}