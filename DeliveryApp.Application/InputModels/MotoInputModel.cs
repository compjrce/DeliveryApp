using DeliveryApp.Domain.Entities;

namespace DeliveryApp.Application.InputModels;

public class MotoInputModel
{
    public int Year { get; set; }
    public string Model { get; set; }
    public string LicensePlate { get; set; }

    public Moto ToEntity() =>
        new Moto(Year, Model, LicensePlate);
}