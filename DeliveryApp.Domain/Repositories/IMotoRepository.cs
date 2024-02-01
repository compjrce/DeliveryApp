using DeliveryApp.Domain.Entities;

namespace DeliveryApp.Domain.Repositories;

public interface IMotoRepository
{
    Task InsertMotoAsync(Moto moto);
}