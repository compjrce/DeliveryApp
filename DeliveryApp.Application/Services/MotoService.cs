using DeliveryApp.Application.InputModels;
using DeliveryApp.Application.ViewModels;
using DeliveryApp.Domain.Repositories;

namespace DeliveryApp.Application.Services;

public class MotoService : IMotoService
{
    private readonly IMotoServiceRepository _repository;

    public MotoService(IMotoServiceRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<MotoViewModel>> GetAllAsync()
    {
        return MotoViewModel.FromEntity(_repository.GetAllAsync().Result);
    }

    public async Task<string> InsertMotoAsync(MotoInputModel model)
    {
        var moto = model.ToEntity();

        await _repository.InsertMotoAsync(moto);

        return moto.Id.ToString();
    }
}