namespace DeliveryApp.Domain.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; private set; }
    public DateTime CreatedOn => DateTime.Now;
}