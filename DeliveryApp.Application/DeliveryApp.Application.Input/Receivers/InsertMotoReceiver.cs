using DeliveryApp.Application.Input.Commands.MotoContext;
using DeliveryApp.Application.Input.Receivers.Interfaces;
using DeliveryApp.Application.Input.Repositories;
using DeliveryApp.Domain.Entities;

namespace DeliveryApp.Application.Input.Receivers;

public class InsertMotoReceiver : IReceiver<MotoCommand>
{
    IWriteMotoRepository _repository;

    InsertMotoReceiver(IWriteMotoRepository repository)
    {
        _repository = repository;
    }

    public void Action(MotoCommand command)
    {
        var moto = new Moto(command.Ano, command.Modelo, command.Placa);

        _repository.InsertMoto(moto);
    }
}