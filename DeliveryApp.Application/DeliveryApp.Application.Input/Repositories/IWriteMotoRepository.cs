using DeliveryApp.Domain.Entities;

namespace DeliveryApp.Application.Input.Repositories;

public interface IWriteMotoRepository
{
    void InsertMoto(Moto moto);
}