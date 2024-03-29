using DeliveryApp.Domain.Entities;

namespace DeliveryApp.Domain.Repositories;

public interface IOrderServiceRepository
{
    Task InsertAsync(Order order);
    Task<Order> GetByIdAsync(Guid id);
}