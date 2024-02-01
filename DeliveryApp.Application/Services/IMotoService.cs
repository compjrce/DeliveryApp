using DeliveryApp.Application.InputModels;

namespace DeliveryApp.Application.Services;

public interface IMotoService
{
    Task<string> InsertMoto(MotoInputModel model);
}