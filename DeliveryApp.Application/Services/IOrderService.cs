using DeliveryApp.Application.InputModels;
using DeliveryApp.Application.ViewModels;

namespace DeliveryApp.Application.Services;

public interface IOrderService
{
    Task<OrderViewModel> InsertAsync(OrderInputModel model);

    Task<OrderViewModel> GetByIdAsync(Guid id);
}