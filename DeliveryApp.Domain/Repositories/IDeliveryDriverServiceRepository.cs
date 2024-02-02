using DeliveryApp.Domain.Entities;

namespace DeliveryApp.Domain.Repositories;

public interface IDeliveryDriverServiceRepository
{
    Task InsertAsync(DeliveryDriver deliveryDriver);

    Task UpdateDriverLicenseImageAsync(string driverLicenseNumber, string driverLicenseImage);
}