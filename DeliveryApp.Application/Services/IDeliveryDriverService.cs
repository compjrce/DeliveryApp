using DeliveryApp.Application.InputModels;
using DeliveryApp.Application.ViewModels;

namespace DeliveryApp.Application.Services;

public interface IDeliveryDriverService
{
    Task<List<DeliveryDriverViewModel>> GetAllAsync();

    Task<string> InsertAsync(DeliveryDriverInputModel model);

    Task UpdateDriverLicenseImageAsync(string driverLicenseNumber, string driverLicenseImage);
}