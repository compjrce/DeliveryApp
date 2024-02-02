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

    public async Task DeleteAsync(string licensePlate)
    {
        await _repository.DeleteAsync(licensePlate);
    }

    public async Task<List<MotoViewModel>> GetAllAsync()
    {
        return MotoViewModel.FromEntity(_repository.GetAllAsync().Result);
    }

    public async Task<MotoViewModel?> GetByLicensePlateAsync(string licensePlate)
    {
        var moto = await _repository.GetByLicensePlateAsync(licensePlate);

        if (moto == null)
            return null;

        return MotoViewModel.FromEntity(moto);
    }

    public async Task<string> InsertAsync(MotoInputModel model)
    {
        var moto = model.ToEntity();

        await _repository.InsertAsync(moto);

        return moto.LicensePlate.ToString();
    }

    public async Task UpdateLicensePlateAsync(string newLicensePlate, string licensePlate)
    {
        await _repository.UpdateLicensePlateAsync(newLicensePlate, licensePlate);
    }
}