using DeliveryApp.Domain.Entities;
using DeliveryApp.Domain.Enums;

namespace DeliveryApp.Application.ViewModels;

public class OrderViewModel
{
    public OrderViewModel(Guid id, DateTime createdOn, double rideCost, EOrderStatus status)
    {
        Id = id;
        CreatedOn = createdOn;
        RideCost = rideCost;
        Status = status;
    }

    public Guid Id { get; private set; }
    public DateTime CreatedOn { get; private set; }
    public double RideCost { get; private set; }
    public EOrderStatus Status { get; private set; }

    public static OrderViewModel FromEntity(Order order) =>
        new(order.Id,
            order.CreatedOn,
            order.RideCost,
            order.Status);
}