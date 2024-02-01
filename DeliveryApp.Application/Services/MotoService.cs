using DeliveryApp.Application.InputModels;
using DeliveryApp.Domain.Repositories;

namespace DeliveryApp.Application.Services;

public class MotoService : IMotoService
{
    private readonly IMotoRepository _repository;

    public MotoService(IMotoRepository repository)
    {
        _repository = repository;
    }

    public async Task<string> InsertMoto(MotoInputModel model)
    {
        var moto = model.ToEntity();

        await _repository.InsertMotoAsync(moto);

        return moto.Id.ToString();
    }
}