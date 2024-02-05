using DeliveryApp.Application.InputModels;
using DeliveryApp.Application.ViewModels;
using DeliveryApp.Domain.Messages;
using DeliveryApp.Domain.Repositories;

namespace DeliveryApp.Application.Services;

public class OrderService : IOrderService
{
    private readonly IOrderServiceRepository _repository;
    private readonly IMessageBusService _messageBus;

    public OrderService(IOrderServiceRepository repository, IMessageBusService messageBus)
    {
        _repository = repository;
        _messageBus = messageBus;
    }

    public async Task<OrderViewModel?> GetByIdAsync(Guid id)
    {
        var order = await _repository.GetByIdAsync(id);

        if (order == null)
            return null;

        return OrderViewModel.FromEntity(order);
    }

    public async Task<OrderViewModel> InsertAsync(OrderInputModel model)
    {
        var order = model.ToEntity();

        await _repository.InsertAsync(order);

        _messageBus.Publish(order, "order-available");

        return OrderViewModel.FromEntity(order);
    }
}