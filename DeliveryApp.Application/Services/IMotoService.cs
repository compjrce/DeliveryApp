using DeliveryApp.Application.InputModels;
using DeliveryApp.Application.ViewModels;

namespace DeliveryApp.Application.Services;

public interface IMotoService
{
    Task<string> InsertMotoAsync(MotoInputModel model);

    Task<List<MotoViewModel>> GetAllAsync();
}