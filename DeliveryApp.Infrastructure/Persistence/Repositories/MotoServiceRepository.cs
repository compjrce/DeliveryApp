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

    public async Task DeleteAsync(string licensePlate)
    {
        var filter = Builders<Moto>.Filter.Eq(x => x.LicensePlate, licensePlate);

        await _collection.FindOneAndDeleteAsync(filter);
    }

    public async Task<List<Moto>> GetAllAsync()
    {
        var filter = Builders<Moto>.Filter.Empty;

        return await _collection.Find(filter).ToListAsync();
    }

    public async Task<Moto> GetByLicensePlateAsync(string licensePlate)
    {
        var filter = Builders<Moto>.Filter.Eq(x => x.LicensePlate, licensePlate);

        return await _collection.Find(filter).FirstOrDefaultAsync();
    }

    public async Task InsertAsync(Moto moto)
    {
        await _collection.InsertOneAsync(moto);
    }

    public async Task UpdateLicensePlateAsync(string newLicensePlate, string licensePlate)
    {
        var filter = Builders<Moto>.Filter.Eq(x => x.LicensePlate, licensePlate);
        var update = Builders<Moto>.Update.Set(x => x.LicensePlate, newLicensePlate);

        await _collection.FindOneAndUpdateAsync(filter, update);
    }
}