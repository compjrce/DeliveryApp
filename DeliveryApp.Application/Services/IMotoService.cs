using DeliveryApp.Application.InputModels;
using DeliveryApp.Application.ViewModels;

namespace DeliveryApp.Application.Services;

public interface IMotoService
{
    Task<MotoViewModel> InsertAsync(MotoInputModel model);

    Task<List<MotoViewModel>> GetAllAsync();

    Task<MotoViewModel> GetByLicensePlateAsync(string licensePlate);

    Task UpdateLicensePlateAsync(string newLicensePlate, string licensePlate);

    Task DeleteAsync(string licensePlate);
}