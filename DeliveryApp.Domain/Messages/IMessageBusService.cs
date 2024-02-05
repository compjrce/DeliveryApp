namespace DeliveryApp.Domain.Messages;

public interface IMessageBusService
{
    void Publish(object data, string routingKey);

}