using DeliveryApp.Application.InputModels;
using DeliveryApp.Application.ViewModels;

namespace DeliveryApp.Application.Services;

public class OrderService : IOrderService
{
    public Task<OrderViewModel> InsertAsync(OrderInputModel model)
    {
        throw new NotImplementedException();
    }
}