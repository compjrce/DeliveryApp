using DeliveryApp.Domain.Entities;

namespace DeliveryApp.Domain.Repositories;

public interface IDeliveryDriverServiceRepository
{
    Task<List<DeliveryDriver>> GetAllAsync();

    Task InsertAsync(DeliveryDriver deliveryDriver);

    Task UpdateDriverLicenseImageAsync(string driverLicenseNumber, string driverLicenseImage);
}