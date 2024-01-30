using DeliveryApp.Application.Input.Commands.Interfaces;

namespace DeliveryApp.Application.Input.Commands.MotoContext;

public class MotoCommand : ICommand
{
    public int Ano { get; private set; }
    public string Modelo { get; private set; }
    public string Placa { get; private set; }
}