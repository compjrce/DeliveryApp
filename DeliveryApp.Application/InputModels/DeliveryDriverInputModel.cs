using DeliveryApp.Domain.Entities;
using DeliveryApp.Domain.Enums;

namespace DeliveryApp.Application.InputModels;

public class DeliveryDriverInputModel
{
    public string Name { get; set; }
    public string CNPJ { get; set; }
    public DateTime BirthDate { get; set; }
    public string DriverLicenseNumber { get; set; }
    public EDriverLicenseType DriverLicenseType { get; set; }

    public DeliveryDriver ToEntity() =>
        new DeliveryDriver(Name, CNPJ, BirthDate, DriverLicenseNumber, DriverLicenseType);
}