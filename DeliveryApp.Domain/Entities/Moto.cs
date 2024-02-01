namespace DeliveryApp.Domain.Entities;

public class Moto : BaseEntity
{
    public Moto(int year, string model, string licensePlate)
    {
        Year = year;
        Model = model;
        LicensePlate = licensePlate;
    }

    public int Year { get; private set; }
    public string Model { get; private set; }
    public string LicensePlate { get; private set; }
}