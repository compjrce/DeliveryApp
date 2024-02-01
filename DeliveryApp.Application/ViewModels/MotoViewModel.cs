using DeliveryApp.Domain.Entities;

namespace DeliveryApp.Application.ViewModels;

public class MotoViewModel
{
    public MotoViewModel(Guid id, DateTime createdOn, int ano, string modelo, string placa)
    {
        Id = id;
        CreatedOn = createdOn;
        Ano = ano;
        Modelo = modelo;
        Placa = placa;
    }

    public Guid Id { get; private set; }
    public DateTime CreatedOn { get; private set; }
    public int Ano { get; private set; }
    public string Modelo { get; private set; }
    public string Placa { get; private set; }

    public static MotoViewModel FromEntity(Moto moto) =>
        new MotoViewModel(moto.Id, moto.CreatedOn, moto.Ano, moto.Modelo, moto.Placa);
}