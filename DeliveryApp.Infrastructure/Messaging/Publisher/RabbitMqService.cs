using System.Text;
using DeliveryApp.Domain.Messages;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace DeliveryApp.Infrastructure.Messaging.Publisher;

public class RabbitMqService : IMessageBusService
{
    private readonly IConnection _connection;
    private readonly IModel _channel;
    private const string _queue = "delivery-app";

    public RabbitMqService()
    {
        var factory = new ConnectionFactory
        {
            HostName = "localhost"
        };

        _connection = factory.CreateConnection();
        _channel = _connection.CreateModel();
    }

    public void Publish(object data, string routingKey)
    {
        var payload = JsonConvert.SerializeObject(data);
        var byteArray = Encoding.UTF8.GetBytes(payload);

        _channel.QueueDeclare(
            queue: _queue,
            durable: true,
            exclusive: false,
            autoDelete: false,
            arguments: null);

        _channel.BasicPublish(
            exchange: string.Empty,
            routingKey: routingKey,
            basicProperties: null,
            body: byteArray);
    }
}