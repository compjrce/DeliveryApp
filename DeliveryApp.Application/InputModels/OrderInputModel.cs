using DeliveryApp.Domain.Entities;
using DeliveryApp.Domain.Enums;

namespace DeliveryApp.Application.InputModels;

public class OrderInputModel
{
    public double RideCost { get; set; }
    public EOrderStatus Status { get; set; }

    public Order ToEntity() =>
        new Order(RideCost);

}