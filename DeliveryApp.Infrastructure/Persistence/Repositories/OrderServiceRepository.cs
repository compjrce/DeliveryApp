using DeliveryApp.Domain.Entities;
using DeliveryApp.Domain.Repositories;
using MongoDB.Driver;

namespace DeliveryApp.Infrastructure.Persistence.Repositories;

public class OrderServiceRepository : IOrderServiceRepository
{
    private readonly IMongoCollection<Order> _collection;

    public OrderServiceRepository(IMongoDatabase database)
    {
        _collection = database.GetCollection<Order>("order");
    }

    public async Task<Order> GetByIdAsync(Guid id)
    {
        var filter = Builders<Order>.Filter.Eq(x => x.Id, id);

        return await _collection.Find(filter).FirstOrDefaultAsync();
    }

    public async Task InsertAsync(Order order)
    {
        await _collection.InsertOneAsync(order);
    }
}