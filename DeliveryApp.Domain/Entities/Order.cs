using DeliveryApp.Domain.Enums;

namespace DeliveryApp.Domain.Entities;

public class Order : BaseEntity
{
    public Order(double rideCost)
    {
        RideCost = rideCost;
        Status = EOrderStatus.Available;
    }

    public double RideCost { get; private set; }
    public EOrderStatus Status { get; private set; }

}