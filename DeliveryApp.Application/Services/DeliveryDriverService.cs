using DeliveryApp.Application.InputModels;
using DeliveryApp.Domain.Repositories;

namespace DeliveryApp.Application.Services;

public class DeliveryDriverService : IDeliveryDriverService
{
    private readonly IDeliveryDriverServiceRepository _repository;

    public DeliveryDriverService(IDeliveryDriverServiceRepository repository)
    {
        _repository = repository;
    }

    public async Task<string> InsertAsync(DeliveryDriverInputModel model)
    {
        var deliveryDriver = model.ToEntity();

        await _repository.InsertAsync(deliveryDriver);

        return deliveryDriver.DriverLicenseNumber;
    }

    public Task UpdateDriverLicenseImageAsync(string driverLicenseNumber, byte[] driverLicenseImage)
    {
        throw new NotImplementedException();
    }
}