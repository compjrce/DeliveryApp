using DeliveryApp.Domain.Entities;

namespace DeliveryApp.Domain.Repositories;

public interface IMotoServiceRepository
{
    Task InsertMotoAsync(Moto moto);
}