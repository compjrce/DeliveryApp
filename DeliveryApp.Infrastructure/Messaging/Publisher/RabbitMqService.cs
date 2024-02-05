using System.Text;
using DeliveryApp.Domain.Messages;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace DeliveryApp.Infrastructure.Messaging.Publisher;

public class RabbitMqService : IMessageBusService
{
    private readonly IConnection _connection;
    private readonly IModel _channel;
    private const string _exchange = "delivery-app";

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

        _channel.BasicPublish(_exchange, routingKey, null, byteArray);
    }
}