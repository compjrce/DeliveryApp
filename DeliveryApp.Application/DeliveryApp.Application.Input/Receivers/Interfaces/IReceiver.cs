using DeliveryApp.Application.Input.Commands.Interfaces;

namespace DeliveryApp.Application.Input.Receivers.Interfaces;

public interface IReceiver<in T> where T : ICommand
{
    void Action(T command);
}