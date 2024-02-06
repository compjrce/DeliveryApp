namespace DeliveryApp.Domain.Entities;

public abstract class BaseEntity
{
    public Guid Id = Guid.NewGuid();
    public DateTime CreatedOn = DateTime.Now;
}