using DeliveryApp.Domain.Entities;

namespace DeliveryApp.Domain.Repositories;

public interface IMotoServiceRepository
{
    Task InsertMotoAsync(Moto moto);

    Task<List<Moto>> GetAllAsync();

    Task<Moto> GetByLicensePlateAsync(string licensePlate);

    Task UpdateLicensePlateAsync(string newLicensePlate, string licensePlate);
}