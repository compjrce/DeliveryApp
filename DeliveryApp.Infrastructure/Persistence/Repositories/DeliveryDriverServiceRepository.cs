using DeliveryApp.Domain.Entities;
using DeliveryApp.Domain.Repositories;
using MongoDB.Driver;

namespace DeliveryApp.Infrastructure.Persistence.Repositories;

public class DeliveryDriverServiceRepository : IDeliveryDriverServiceRepository
{
    private readonly IMongoCollection<DeliveryDriver> _collection;

    public DeliveryDriverServiceRepository(IMongoDatabase database)
    {
        _collection = database.GetCollection<DeliveryDriver>("delivery-driver");
    }

    public async Task<List<DeliveryDriver>> GetAllAsync()
    {
        var filter = Builders<DeliveryDriver>.Filter.Empty;

        return await _collection.Find(filter).ToListAsync();
    }

    public async Task InsertAsync(DeliveryDriver deliveryDriver)
    {
        await _collection.InsertOneAsync(deliveryDriver);
    }

    public async Task UpdateDriverLicenseImageAsync(string driverLicenseNumber, string driverLicenseImage)
    {
        var filter = Builders<DeliveryDriver>.Filter.Eq(x => x.DriverLicenseNumber, driverLicenseNumber);
        var update = Builders<DeliveryDriver>.Update.Set(x => x.DriverLicenseImage, driverLicenseImage);

        await _collection.FindOneAndUpdateAsync(filter, update);
    }
}