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

    public async Task InsertAsync(DeliveryDriver deliveryDriver)
    {
        await _collection.InsertOneAsync(deliveryDriver);
    }

    public Task UpdateDriverLicenseImageAsync(string driverLicenseNumber, byte[] driverLicenseImage)
    {
        throw new NotImplementedException();
    }
}