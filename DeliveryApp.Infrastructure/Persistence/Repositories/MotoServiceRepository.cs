using DeliveryApp.Domain.Entities;
using DeliveryApp.Domain.Repositories;
using MongoDB.Driver;

namespace DeliveryApp.Infrastructure.Persistence.Repositories;

public class MotoServiceRepository : IMotoServiceRepository
{
    private readonly IMongoCollection<Moto> _collection;

    public MotoServiceRepository(IMongoDatabase database)
    {
        _collection = database.GetCollection<Moto>("moto");
    }

    public async Task<List<Moto>> GetAllAsync()
    {
        var filter = Builders<Moto>.Filter.Empty;

        return await _collection.Find(filter).ToListAsync();
    }

    public async Task InsertMotoAsync(Moto moto)
    {
        await _collection.InsertOneAsync(moto);
    }
}