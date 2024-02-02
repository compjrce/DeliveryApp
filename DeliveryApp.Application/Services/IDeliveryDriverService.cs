using DeliveryApp.Application.InputModels;

namespace DeliveryApp.Application.Services;

public interface IDeliveryDriverService
{
    Task<string> InsertAsync(DeliveryDriverInputModel model);

    Task UpdateDriverLicenseImageAsync(string driverLicenseNumber, string driverLicenseImage);
}