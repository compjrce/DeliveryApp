using DeliveryApp.Application.InputModels;
using DeliveryApp.Application.ViewModels;
using DeliveryApp.Domain.Repositories;

namespace DeliveryApp.Application.Services;

public class DeliveryDriverService : IDeliveryDriverService
{
    private readonly IDeliveryDriverServiceRepository _repository;

    public DeliveryDriverService(IDeliveryDriverServiceRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<DeliveryDriverViewModel>> GetAllAsync()
    {
        return DeliveryDriverViewModel.FromEntity(_repository.GetAllAsync().Result);
    }

    public async Task<string> InsertAsync(DeliveryDriverInputModel model)
    {
        var deliveryDriver = model.ToEntity();

        await _repository.InsertAsync(deliveryDriver);

        return deliveryDriver.DriverLicenseNumber;
    }

    public async Task UpdateDriverLicenseImageAsync(string driverLicenseNumber, string driverLicenseImage)
    {
        await _repository.UpdateDriverLicenseImageAsync(driverLicenseNumber, driverLicenseImage);
    }
}