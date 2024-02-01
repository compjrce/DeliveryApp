using DeliveryApp.Domain.Entities;

namespace DeliveryApp.Application.InputModels;

public class MotoInputModel
{
    public int Ano { get; private set; }
    public string Modelo { get; private set; }
    public string Placa { get; private set; }

    public Moto ToEntity() =>
        new Moto(Ano, Modelo, Placa);
}